﻿using System;

namespace VanillaTransformer.Transformers
{
    [Obsolete("Use GenericPlaceholderTransformer", false)]
    public class HashBracketPlaceholderTransformer : GenericPlaceholderTransformer
    {
        public HashBracketPlaceholderTransformer() : base("#[KEY]")
        {
        }
    }
}
