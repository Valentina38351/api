﻿using System.Collections.Generic;

namespace MareSynchronos.API
{
    public record CharacterCacheDto
    {
        public ObjectKind ObjectKind { get; set; }
        public List<FileReplacementDto> FileReplacements { get; set; } = new();
        public string GlamourerData { get; set; }
        public string ManipulationData { get; set; }
        public string Hash { get; set; }
    }
}
