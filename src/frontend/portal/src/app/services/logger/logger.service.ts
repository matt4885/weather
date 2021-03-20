import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class LoggerService {

  constructor() { }

  /**
   * log
   */
  public log(message: string): void {
    console.log(message);
  }

  /**
   * warn
   */
  public warn(message: string): void {
    console.warn(message);
  }

  /**
   * error
   */
  public error(message: string): void {
    console.error(message);
  }
}
