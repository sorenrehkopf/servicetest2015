app.controller('DashCtrl', ['$scope','$rootScope','Part','$modal',function ($scope,$rootScope,Part,$modal) {
	$scope.parts = [];
	Part.query(function (parts) {
		parts.forEach(function (part) {
			if (part.Parts.length > 0) {
				for (i = 0; i < part.Parts.length; i++) {
					if (!part.Parts[i].Received) {
						$scope.parts.push({
							recordNum: part.Id,
							orderNum: part.Parts[i].OrderNo,
							qty: part.Parts[i].Qty,
							partNum: part.Parts[i].PartNo,
							days: Math.floor((new Date().getTime() / (1000 * 60 * 60 * 24)) - (new Date(part.Parts[i].OrderedOn).getTime() / (1000 * 60 * 60 * 24)))
						})
					}
				}
			}
		})
		console.log($scope.parts)
	});
	$scope.openModal = function(recordId,partId,index) {
				
		var modalInstance = $modal.open({
			templateUrl: 'app/views/modals/modal.html',
			controller: 'ModalCtrl',
			resolve: {
				id: function () {
					return recordId;
				},
				partId: function () {
					return partId
				}
			}
		});

		modalInstance.result.then(function (selectedItem) {
			
		}, function () {
			$scope.parts.splice(index,1)
		});
	};

}]);