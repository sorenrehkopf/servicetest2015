app.controller('ModalCtrl', function ($scope, $modalInstance, id, partId, Part) {
	$scope.id = id;
	$scope.partId = partId;
	$scope.closeModal = function () {
		$modalInstance.dismiss()
	};
	$scope.name = {
		username: ""
	};
	$scope.update = function () {
		var name = $scope.name.username;
		var record = Part.get({ id: $scope.id }, function(record){
			for(i=0;i<record.Parts.length;i++){
				if (record.Parts[i].PartNo === $scope.partId) {
					record.Parts[i].Received = true;
					record.Parts[i].ReceivingInfo.ReceivedBy = $scope.name.username;
					record.Parts[i].ReceivingInfo.ReceivedOn = new Date();
				}
			}
			record.$update(function () {
				$scope.closeModal();
			})
		})
	}
});
