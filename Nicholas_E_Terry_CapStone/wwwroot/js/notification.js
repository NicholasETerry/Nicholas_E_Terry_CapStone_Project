"use strict"

(async () => {
    // create and show the notification
    const showNotification = () => {
        // create a new notification
        const notification = new Notification('Your Experience is needed !', {
            body: 'There Is An Article That Needs Review',
            icon: './img/js.png',
            vibrate: true
        });

        // close the notification after 10 seconds
        setTimeout(() => {
            notification.close();
        }, 10 * 1000);

        // navigate to a URL when clicked
        notification.addEventListener('click', () => {

            window.open('', '_blank'); // need to put reveiw link here ! 
        });
    }

    // show an error message
    const showError = () => {
        const error = document.querySelector('.error');
        error.style.display = 'block';
        error.textContent = 'You blocked notifications. You will not be able to Review Articles';
    }
    const showSuccess = () => {
        const success = document.querySelector('.success');
        success.style.display = 'block';
        success.textContent = 'Great ! You are ready to Recieve Articles for Review. ';
    }


    // check notification permission
    let granted = false;

    if (Notification.permission === 'granted') {
        granted = true;
    } else if (Notification.permission !== 'denied') {
        let permission = await Notification.requestPermission();
        granted = permission === 'granted' ? true : false;
    }
    if (granted == true) {
        showSuccess();
    }
    // show notification or error
    granted ? showNotification() : showError();

})();