import { Pipe } from "@angular/core";

@Pipe ({
    name: 'replace'
})
export class ReplacePipe {
    transform(valeu: string, char: string, valueToReplace: string) {
        return valeu.replace(char, valueToReplace);
    }
}