public static class Identifier
{
    public static string Clean(string identifier)
    {
        string newIdentifier = ""; 
        char[] greekLetters = ['α', 'β', 'γ', 'δ', 'ε', 'ζ', 'η', 'θ', 'ι', 'κ', 'λ', 'μ', 'ν', 'ξ', 'π', 'ρ', 'σ', 'τ', 'υ', 'φ', 'χ', 'ψ', 'ω'];

        for(int i = 0; i < identifier.Length; i++){
            
            if(identifier[i] == ' '){
                 newIdentifier += '_';
            }else if(identifier[i] == '\0' ){
               newIdentifier += "CTRL";
           }else if (identifier[i] == '-')
            {
                char nextLetter = char.ToUpper(identifier[i +1]);
                newIdentifier += nextLetter;
                i++;
            }else if(!Char.IsLetter(identifier[i])){
                continue;
            }else if (Array.Exists(greekLetters, letter => letter == identifier[i] )){
                continue;
                
            }
           else{
               newIdentifier += identifier[i];
           }
        }

        return newIdentifier;            
    }
}
