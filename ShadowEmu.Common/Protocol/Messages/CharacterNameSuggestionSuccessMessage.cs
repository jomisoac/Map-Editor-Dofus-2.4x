


















// Generated on 01/12/2017 03:52:54
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class CharacterNameSuggestionSuccessMessage : NetworkMessage
{

public const uint Id = 5544;
public uint MessageId
{
    get { return Id; }
}

public string suggestion;
        

public CharacterNameSuggestionSuccessMessage()
{
}

public CharacterNameSuggestionSuccessMessage(string suggestion)
        {
            this.suggestion = suggestion;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(suggestion);
            

}

public void Deserialize(IDataReader reader)
{

suggestion = reader.ReadUTF();
            

}


}


}