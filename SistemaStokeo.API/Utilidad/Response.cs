﻿namespace SistemaStokeo.API.Utilidad
{
    public class Response<T> 
    {
        public bool status { get; set; }
        public T value { get; set; }
        public string msg { get; set; }
        public string Token { get; set; }

    }
}