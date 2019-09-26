var verification = function () {
    var vuname = document.getElementById("name1").value;
    var vpass1 = document.getElementById("pass1").value;
    var vpass2 = document.getElementById("pass2").value;
    var vname = document.getElementById("name2").value;
    var vzip = document.getElementById("zip1").value;
    var vmail = document.getElementById("mail1").value;


    var vdate = document.getElementById("dob").value;
    console.log(vdate)

    var runame = /^[A-Za-z0-9]{5,12}$/;
    var funame = runame.test(vuname);

    var rpass = /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*\W){7,12}$/;
    var fpass1 = rpass.test(vpass1);
    console.log(fpass1)

    var rname = /^[A-Za-z]{2,}\s[a-zA-z]{2,}$/;
    var fname = rname.test(vname);

    var rzip = /^[0-9]{3,}-[0-9]{3,}$/;
    var fzip = rzip.test(vzip);

    var rmail = /^[A-Za-z0-9.-_]{4,}@[A-Za-z0-9]{1,}\.[a-z]{2,3}$/;
    var fmail = rmail.test(vmail);

    if (vpass1 == vpass2) {
        var spass = true;
    }
    else {
        spass = false;
    }


    var vdob = document.getElementById("dob").value;
    var yr1 = new Date(vdob).getFullYear();
    var yr2 = new Date().getFullYear();
    var yrdiff;

    yrdiff = yr2 - yr1;






    console.log(spass)

    if (funame == false) {
        alert("Enter a valid User Id!");
    }
    else if (fpass1 == false) {
        alert("Enter a valid password!");
    }
    else if (spass == false) {
        alert("Enter same password as created earlier!");
    }
    else if (fname == false) {
        alert("Enter valid first name and last name!");
    }
    else if (fzip == false) {
        alert("Enter a valid ZIP code!");
    }
    else if (fmail == false) {
        alert("enter valid Email id");
    }
    else if (yrdiff < 18) {
        alert("You should be over 18 to register!");
    }
    else {
        alert("Registration successful!")
    }






}