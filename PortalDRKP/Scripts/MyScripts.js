function my_f(objName) {
    var objects = document.getElementsByClassName(objName);
    for (var i = 0, cnt = objects.length; i < cnt; i++) {
        objects[i].style.display = (objects[i].style.display === 'none') ? 'block' : 'none';
    }
}

function f_in(inp) {
    var objects = document.getElementsByClassName("EmpMenu");
    for (var i = 0, cnt = objects.length; i < cnt; i++) {
        if (inp === 1) {
            objects[i].style.backgroundImage = 'url("../Images/EmpEdit.png")';
        }
        if (inp === 2) {
            objects[i].style.backgroundImage = 'url("../Images/EmpKPI.png")';
        }
        if (inp === 3) {
            objects[i].style.backgroundImage = 'url("../Images/EmpDetails.png")';
        }

    }
}
function f_out() {
    var objects = document.getElementsByClassName("EmpMenu");
    for (var i = 0, cnt = objects.length; i < cnt; i++) {
        objects[i].style.backgroundImage = 'url("../Images/EmpEmty.png")';
    }
}


function S_in(inp) {
    //var objects = document.getElementsByClassName("SubMenu");
    //for (var i = 0, cnt = objects.length; i < cnt; i++) {
    //    if (inp === 1) {
    //        objects[i].style.backgroundImage = 'url("../Images/EmpEdit.png")';
    //    }
    //    if (inp === 2) {
    //        objects[i].style.backgroundImage = 'url("../Images/EmpKPI.png")';
    //    }
    //    if (inp === 3) {
    //        objects[i].style.backgroundImage = 'url("../Images/EmpDetails.png")';
    //    }

    //}
}
function S_out() {
    //var objects = document.getElementsByClassName("SubMenu");
    //for (var i = 0, cnt = objects.length; i < cnt; i++) {
    //    objects[i].style.backgroundImage = 'url("../Images/EmpEmty.png")';
    //}
}
