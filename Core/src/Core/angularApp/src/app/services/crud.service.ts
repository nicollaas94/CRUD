import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import { HttpHelper } from '../utils/HttpHelper';
import { Observable } from 'rxjs/Observable';
import 'rxjs/Rx';

@Injectable()
export class CrudService extends HttpHelper {

    private _carregaCandidatos = 'crud/listar';
    private _carregaCandidatoEspecifico = 'crud/pegarCandidato';
    private _cadastraCandidato = 'crud/cadastrar';
    private _excluirCandidato = 'crud/excluir';
    private _alterarCandidato = 'crud/alterar';

    constructor(private http: Http) {
        super(http);
    }
    carregaCandidatos(): Observable<Array<DTO.Candidato>> {
        let result = this.getaction(this._carregaCandidatos, ).map(
            result => {
                let tmp = <Array<DTO.Candidato>>result;
                return tmp;
            }
        ).catch(err => { return Observable.throw(err || 'Server error'); });
        return result;
    }
    cadastraCandidatos(candidato: DTO.Candidato): Observable<Boolean> {
        let result = this.postaction(this._cadastraCandidato, candidato).map(
            result => {
                let tmp = result;
                return tmp;
            }
        ).catch(err => { return Observable.throw(err || 'Server error'); });
        return result;

    }
    excluirCandidato(idCandidato: number): Observable<Boolean> {
        let result = this.deleteaction(this._excluirCandidato, { candidatoId: idCandidato }).map(
            result => {
                let tmp = result;
                return tmp;
            }
        ).catch(err => { return Observable.throw(err || 'Server error'); });
        return result;
    }

    carregaCandidatoEspecifico(candidatoId: number): Observable<DTO.Candidato> {
        let result = this.getaction(this._carregaCandidatoEspecifico, { candidatoId: candidatoId }).map(
            result => {
                let tmp = <DTO.Candidato>result;
                return tmp;
            }
        ).catch(err => { return Observable.throw(err || 'Server error'); });
        return result;
    }
    alterarCandidato(candidato: DTO.Candidato): Observable<Boolean> {
        let result = this.putaction(this._alterarCandidato, candidato).map(
            result => {
                let tmp = result;
                return tmp;
            }
        ).catch(err => { return Observable.throw(err || 'Server error'); });
        return result;
    }

}