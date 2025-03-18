const IS_ABSENT = 6;
let empCheck = Math.floor(Math.random()*10)%2;
if(empCheck== IS_ABSENT){
    console.log("Employee is Absent");
    return;
}
else{
    console.log("Employee is Present");
}