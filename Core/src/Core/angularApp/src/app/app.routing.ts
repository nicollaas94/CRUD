import { NgModule }             from '@angular/core';
import { RouterModule, Routes } from '@angular/router';


import { ListarComponent } from './components/listar/listar.component';
import { EditarComponent } from './components/editar/editar.component';
import { CriarComponent } from './components/criar/criar.component';
import { DetalhesComponent } from './components/detalhes/detalhes.component';

const routes: Routes = [
    //
    //{ path: '*', redirectTo: 'login'},
    { path: '', component: ListarComponent},
    { path: 'editar/:id', component: EditarComponent},
    { path: 'candidato/:id', component: DetalhesComponent},
    { path: 'criar', component: CriarComponent},
    { path: 'editar', component: ListarComponent},
    { path: 'excluir', component: ListarComponent},
    //{ path: '**', redirectTo: '', pathMatch: 'full' }
];

export const AppRouting = RouterModule.forRoot(routes);
