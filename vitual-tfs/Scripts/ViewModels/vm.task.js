
$(function () {

    function getViewModel() {
        var self = this;
        $.ajax({
            type: "POST",
            url: "/Task/GetViewModel",
            contentType: "application/json",
            dataType: "json",
            async: false,
            success: function (data) {
                self.iterationList = data.Iterations;
                self.title = "Title";
                self.assignedList = data.Users;
                self.assignedSelected = data.Users[1].UserId;
                self.stateList = data.States;
                self.blockList = data.Blocks;
                self.areaList = data.Areas;
                self.activityList = data.Activities;
                self.iterationSelected = data.Iterations[1].Id;
                self.remainingWork = "";
                self.priority = "";
                self.stateSelected = data.States[1].Id;
                self.blockSelected = data.Blocks[1].Id;
                self.description = "";
                self.areaSelected = data.Areas[1].Id;
            }
        });       
      
        self.create = function () {
            var task = {
                Title: self.title,
                EstimatedOrEffort: self.remainingWork,
                Priority: self.priority,
                Iteration: self.iterationSelected,
                AssignedTo: self.assignedSelected,
                Status: self.stateSelected,
                Block: self.blockSelected,
                Description: self.description,
                Area: self.areaSelected,
            };
            //Ajax call to Insert the Employee
            $.ajax({
                type: "POST",
                url: "/Task/CreateTask",
                data: ko.toJSON(task),
                    //Convert the Observable Data into JSON
                contentType: "application/json",
                success: function (data) {
                    alert(data.toString());
                },
                error: function () {
                    alert("Failed");
                }
            });
            //Ends Here
        };

        return self;
    };

    ko.applyBindings(getViewModel());
});

