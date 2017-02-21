import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';

//import { HTTP_PROVIDERS } from '@angular/http';

import { HttpModule, JsonpModule } from '@angular/http';

//navegando 
import { AppRouting } from './app.routing';

//alert
import { AlertService } from './utils/alert';
import { AlertComponent } from './components/alert/alert.component';


//Modulos
import { IndexComponent } from './components/index/index.component';
import { headerComponent } from './components/header/header.component';
import { AppComponent } from './components/app.component';

//INJETAVEL CUSTOM

import { CrudService } from './services/crud.service';
import { ListarComponent } from './components/listar/listar.component';
import { EditarComponent } from './components/editar/editar.component';
import { CriarComponent } from './components/criar/criar.component';

@NgModule({
    imports:
    [
        BrowserModule,
        FormsModule,
        AppRouting,

        HttpModule,
        JsonpModule
    ],
    providers: [
        //HTTP_PROVIDERS,
        CrudService,
        AlertService  
    ],
    declarations: [
        AlertComponent,
        IndexComponent,
        headerComponent,
        AppComponent,
        ListarComponent,
        EditarComponent,
        CriarComponent,
    ],
    bootstrap: [AppComponent]
})
export class AppModule { }