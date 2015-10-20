app.controller('ModalCtrl', function ($scope, $modalInstance, id, Part) {
	$scope.id = id;
	$scope.closeModal = function () {
		$modalInstance.dismiss()
	};
	$scope.name = {
		username: ""
	};
	$scope.update = function () {
		var name = $scope.name.username;
		Part.get({ id: $scope.id }, function (part) {
			console.log(part)
		})
	}
});
