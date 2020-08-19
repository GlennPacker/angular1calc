app.controller('calc', ['calcResource', function (calcResource) {
    var self = this;

    self.currentValue = ''; 

    self.furtherCalculationDisable = function () {
        val = self.currentValue
        if (!val.length) return false;
        val = val.substring(0, val.length - 1); // allow the user to change there expression
        return val.includes('+') || val.includes('-') || val.includes('*') || val.includes('/');
    }

    self.buttonClick = function (buttonValue) {
        if (self.currentValue === 'Error') self.currentValue = '';
       
        var lastWas = self.currentValue.slice(-1)
        if (['+', '-', '*', '/'].includes(lastWas) && ['+', '-', '*', '/'].includes(buttonValue)) { 
            self.currentValue = self.currentValue.substring(0, self.currentValue.length - 1);
        }
        self.currentValue = self.currentValue.concat(buttonValue);
    }

    self.clearScreen = function () {
        self.currentValue = '';
    }

    self.runCalculation = function () {
        calcResource
            .query({ sum: self.currentValue })
            .$promise
            .then(function (data) {
                self.currentValue = data.result;
            })
            .catch(function () {
                self.currentValue = 'Error';
            })
    }
}]);