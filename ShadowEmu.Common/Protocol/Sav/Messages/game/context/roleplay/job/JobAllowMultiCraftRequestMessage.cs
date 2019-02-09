


















// Generated on 07/24/2016 18:35:52
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class JobAllowMultiCraftRequestMessage : NetworkMessage
{

public const uint Id = 5748;
public uint MessageId
{
    get { return Id; }
}

public bool enabled;
        

public JobAllowMultiCraftRequestMessage()
{
}

public JobAllowMultiCraftRequestMessage(bool enabled)
        {
            this.enabled = enabled;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(enabled);
            

}

public void Deserialize(IDataReader reader)
{

enabled = reader.ReadBoolean();
            

}


}


}