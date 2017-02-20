import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import { HttpHelper } from '../utils/HttpHelper';
import { Observable } from 'rxjs/Observable';
import 'rxjs/Rx';

@Injectable()
export class CrudService extends HttpHelper {

    private _carregaCandidatos = 'crud/listar';
    private _cadastraCandidato = 'crud/cadastrar';

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

}