var elements = document.querySelectorAll('[data-val="true"]')
for (let element of elements) {
    element.addEventListener("keyup", function (e) {
        switch (e.target.type) {
            case 'text':
                validateText(e.target, 2);
                break;

            case 'password':
                validatePassword(e.target);
                break;

            case 'email':
                validateEmail(e.target);
                break;
        }
    })
}

function validateText(target, minLength) {
    if (target.value.length < minLength)
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = `${target.id} is invalid`
    else 
            document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = ""
}

function validatePassword(target) {
    const passwordRegex = /^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[^a-zA-Z0-9]).{8,}$/;
    if (!passwordRegex.test(target.value))
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = `${target.id} is invalid`
    else
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = ""

    return passwordRegex.test(value);
}

function validateEmail(target) {
    const emailRegex = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;
    if (!emailRegex.test(target.value))
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = `${target.id} is invalid`
    else
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = ""

    return emailRegex.test(value);
}