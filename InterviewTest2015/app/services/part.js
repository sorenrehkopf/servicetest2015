app.factory('Part', function ($resource) {
	return $resource('/api/record/:id', { id: '@_id' }, {
		update: {
			method: 'PUT'
		}
	});
})