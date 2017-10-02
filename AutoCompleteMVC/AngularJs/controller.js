app.controller('mycontroller', function ($scope, autocompleteservice) {
    $scope.countries = [];
    $scope.SelectedCountry = null;

    $scope.afterSelectedCountry = function (selected)
    {
        if (selected) {
            $scope.selectedCountry = selected.originalObject;
        }
    }

    $scope.inputchanged = function (searchStr)
    {
        autocompleteservice.GetCountryOrderList(searchStr).then(function (response) {
            $scope.countries = response.data;
        }, function () {
            alert('error');
        })
    }
})