import { Pipe, PipeTransform } from '@angular/core';
/*
 * Raise the value exponentially
 * Takes an exponent argument that defaults to 1.
 * Usage:
 *   value | exponentialStrength:exponent
 * Example:
 *   {{ 2 | exponentialStrength:10 }}
 *   formats to: 1024
*/
@Pipe({name: 'discount'})
export class ExponentialStrengthPipe implements PipeTransform {
  transform(value: number, discount?: number): any {

    const valueDiscounted = value - (value * discount / 100);

    return discount <= 10 ? valueDiscounted + " até o dia 11" : ("1,99 até amanha");
  }
}