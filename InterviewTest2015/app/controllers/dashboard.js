app.controller('DashCtrl', ['$scope','$rootScope','Part',function($scope,$rootScope,Part) {
	console.log('heeey!!!');
	$scope.parts = []
	Part.query(function(parts) {
		parts.forEach(function(part){
			if (part.Parts.length > 0) {
				for (i = 0; i < part.Parts.length; i++) {
					if (!part.Parts[i].Received) {
						$scope.parts.push({
							recordNum:part.Id,
							orderNum:part.Parts[i].OrderNo,
							qty: part.Parts[i].Qty,
							partNum: part.Parts[i].PartNo,
							days: Math.floor((new Date().getTime() / (1000 * 60 * 60 * 24)) - (new Date(part.Parts[i].OrderedOn).getTime() / (1000 * 60 * 60 * 24)))
						})
					}
				}
			}
		})
		console.log($scope.parts)
	})
}])