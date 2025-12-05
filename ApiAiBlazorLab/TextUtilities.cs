namespace ApiAiBlazorLab {
    public static class TextUtilities {

        public static string NormalizeFact(string? fact) {

            if (string.IsNullOrWhiteSpace(fact)) {
                return "No fact available.";
            } // End if

            fact = fact.Trim();

            return fact.EndsWith(".") ? fact : fact + ".";

        } // End static
        

    } // End class
} // End namespace

