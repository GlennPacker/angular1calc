angular.module('calc').factory('calcResource', [
    '$resource',
    function ($resource) {
        var api = 'api/v1/calc?sum=:sum';
        return $resource(api, { sum: '@sum' }, {
            query: {
                method: 'Post',
                url: api
            },
            //params: {
            //    sum: '@sum'
            //}
        });
    }
]);