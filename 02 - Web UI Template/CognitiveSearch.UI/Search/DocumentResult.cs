﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.Azure.Search.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CognitiveSearch.UI
{
    public class DocumentResult
    {
        public List<object> Facets { get; set; }
        public Document Result { get; set; }
        public IList<Microsoft.Azure.Search.Models.SearchResult<Microsoft.Azure.Search.Models.Document>> Results { get; set; }
        public int? Count { get; set; }
        public string Token { get; set; }
        public List<object> Tags { get; set; }
        public string SearchId { get; set; }
    }
}
