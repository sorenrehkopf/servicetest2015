app.controller('DashCtrl', ['$scope','$rootScope','Part','$modal',function ($scope,$rootScope,Part,$modal) {
	$scope.parts = [];
	$scope.getParts = function () {
		Part.query(function (parts) {
			var osparts = [];
			parts.forEach(function (part) {
				if (part.Parts.length > 0) {
					for (i = 0; i < part.Parts.length; i++) {
						if (!part.Parts[i].Received) {
							osparts.push({
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
			$scope.parts = osparts;
			console.log($scope.parts)
		});
	};
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

		modalInstance.result.then(function () {
			
		}, function () {
			$scope.getParts();
		});
	};
	
	$scope.getParts();

}]);