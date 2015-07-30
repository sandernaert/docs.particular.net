﻿namespace Snippets4
{
    using NServiceBus;

    public class Serialization
    {
        public void AllTheSerialization()
        {

            #region BinarySerialization

            Configure.Serialization.Binary();
        
            #endregion

            #region BsonSerialization

            Configure.Serialization.Bson();

            #endregion

            #region JsonSerialization

            Configure.Serialization.Json();
        
            #endregion

            #region XmlSerialization

            Configure.Serialization.Xml();

            #endregion
        }

    }
}