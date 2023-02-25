//function for changing the pages
// var selected=false;
function changepage(current, next) {
    document.getElementById(current).style.display = 'none';
    document.getElementById(next).style.display = 'block';
}
//get name
var name = '';
function getname() {
    //console.log(document.getElementById('name').value);
    name = document.getElementById('name').value;
    //console.log(name);
}

////check the answer

//function checkans() {
//    var val = document.getElementById('stars').value;
//    val = parseInt(val);
//    if (val == 52) {
//        scorecount();
//    }
//}

function optionselect0(option) {
    var cols = document.getElementsByClassName('0option1');
    for (i = 0; i < cols.length; i++) {
        cols[i].style.backgroundColor = '#B3E5FC';
    }
    var cols = document.getElementsByClassName('0option2');
    for (i = 0; i < cols.length; i++) {
        cols[i].style.backgroundColor = '#B3E5FC';
    }
    var cols = document.getElementsByClassName('0option3');
    for (i = 0; i < cols.length; i++) {
        cols[i].style.backgroundColor = '#B3E5FC';
    }
    var cols = document.getElementsByClassName('0option4');
    for (i = 0; i < cols.length; i++) {
        cols[i].style.backgroundColor = '#B3E5FC';
    }

    var cols = document.getElementsByClassName(option);
    for (i = 0; i < cols.length; i++) {
        cols[i].style.backgroundColor = 'blue';
    }

    // console.log(option);
}

function optionselect1(option) {
    var cols = document.getElementsByClassName('1option1');
    for (i = 0; i < cols.length; i++) {
        cols[i].style.backgroundColor = '#B3E5FC';
    }
    var cols = document.getElementsByClassName('1option2');
    for (i = 0; i < cols.length; i++) {
        cols[i].style.backgroundColor = '#B3E5FC';
    }
    var cols = document.getElementsByClassName('1option3');
    for (i = 0; i < cols.length; i++) {
        cols[i].style.backgroundColor = '#B3E5FC';
    }
    var cols = document.getElementsByClassName('1option4');
    for (i = 0; i < cols.length; i++) {
        cols[i].style.backgroundColor = '#B3E5FC';
    }

    var cols = document.getElementsByClassName(option);
    for (i = 0; i < cols.length; i++) {
        cols[i].style.backgroundColor = 'blue';
    }

}

function optionselect2(option) {
    var cols = document.getElementsByClassName('2option1');
    for (i = 0; i < cols.length; i++) {
        cols[i].style.backgroundColor = '#B3E5FC';
    }
    var cols = document.getElementsByClassName('2option2');
    for (i = 0; i < cols.length; i++) {
        cols[i].style.backgroundColor = '#B3E5FC';
    }
    var cols = document.getElementsByClassName('2option3');
    for (i = 0; i < cols.length; i++) {
        cols[i].style.backgroundColor = '#B3E5FC';
    }
    var cols = document.getElementsByClassName('2option4');
    for (i = 0; i < cols.length; i++) {
        cols[i].style.backgroundColor = '#B3E5FC';
    }

    var cols = document.getElementsByClassName(option);
    for (i = 0; i < cols.length; i++) {
        cols[i].style.backgroundColor = 'blue';
    }

}

function optionselect3(option) {
    var cols = document.getElementsByClassName('3option1');
    for (i = 0; i < cols.length; i++) {
        cols[i].style.backgroundColor = '#FFEB3B';
    }
    var cols = document.getElementsByClassName('3option2');
    for (i = 0; i < cols.length; i++) {
        cols[i].style.backgroundColor = '#FFEB3B';
    }
    var cols = document.getElementsByClassName('3option3');
    for (i = 0; i < cols.length; i++) {
        cols[i].style.backgroundColor = '#FFEB3B';
    }
    var cols = document.getElementsByClassName('3option4');
    for (i = 0; i < cols.length; i++) {
        cols[i].style.backgroundColor = '#FFEB3B';
    }

    var cols = document.getElementsByClassName(option);
    for (i = 0; i < cols.length; i++) {
        cols[i].style.backgroundColor = 'blue';
    }

}

function optionselect4(option) {
    var cols = document.getElementsByClassName('4option1');
    for (i = 0; i < cols.length; i++) {
        cols[i].style.backgroundColor = '#B3E5FC';
    }
    var cols = document.getElementsByClassName('4option2');
    for (i = 0; i < cols.length; i++) {
        cols[i].style.backgroundColor = '#B3E5FC';
    }
    var cols = document.getElementsByClassName('4option3');
    for (i = 0; i < cols.length; i++) {
        cols[i].style.backgroundColor = '#B3E5FC';
    }
    var cols = document.getElementsByClassName('4option4');
    for (i = 0; i < cols.length; i++) {
        cols[i].style.backgroundColor = '#B3E5FC';
    }

    var cols = document.getElementsByClassName(option);
    for (i = 0; i < cols.length; i++) {
        cols[i].style.backgroundColor = 'blue';
    }

}

//score
var score = 0;

function scorecount() {
    score++;
    // selected=true;
    //console.log(score);
}

//final score

function finalscore()
{
    document.getElementById('scorevalue').innerHTML = score;
    document.getElementById('ch_name').innerHTML = document.getElementById('name').value;
    document.getElementById('challenger_name').innerHTML = document.getElementById('name').value;
    document.getElementById('challenger_score').innerHTML = score;

}

//$('#challenger_name').value = document.getElementById('name').value;


function openPage(pageName, elmnt, color)
{
    var i, tabcontent, tablinks;
    tabcontent = document.getElementsByClassName("tabcontent");
    for (i = 0; i < tabcontent.length; i++)
    {
        tabcontent[i].style.display = "none";
    }
    tablinks = document.getElementsByClassName("tablink");
    for (i = 0; i < tablinks.length; i++)
    {
        tablinks[i].style.backgroundColor = "";
    }
    document.getElementById(pageName).style.display = "block";
    elmnt.style.backgroundColor = color;
}