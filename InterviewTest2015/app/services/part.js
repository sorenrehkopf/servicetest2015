app.factory('Part', function ($resource) {
	return $resource('/api/record');
})