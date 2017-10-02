app.service('autocompleteservice', function ($http) {
    this.GetCountryOrderList = function (searchStr) {
        var response = $http({
            method: 'Post',
            url: '/Test/GetCountryOrder',
            data: { searchStr: searchStr },
            headers: { 'content-Type': 'application/json' }
        });
        return response;
    }
})
