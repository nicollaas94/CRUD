import { Component, OnInit } from '@angular/core';

import { AlertService } from '../../utils/alert';

@Component({
    selector: 'alert',
    templateUrl: './alert.component.html'
})

export class AlertComponent {
    message: any;
    isVisible: boolean = false;

    constructor(private alertService: AlertService) { }

    ngOnInit() {
        this.alertService.getMessage().subscribe(
        message =>
            {
            this.message = message;
            this.isVisible = message.text? true: false;
                if (message.timeOut > 0) {
                    let _self = this;
                    setInterval(function () { _self.isVisible = false }, message.timeOut);
                }
             });
    }

    close() {
        this.isVisible = false;
    }
}