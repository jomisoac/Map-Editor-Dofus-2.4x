


















// Generated on 07/24/2016 18:35:56
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class FriendWarnOnLevelGainStateMessage : NetworkMessage
{

public const uint Id = 6078;
public uint MessageId
{
    get { return Id; }
}

public bool enable;
        

public FriendWarnOnLevelGainStateMessage()
{
}

public FriendWarnOnLevelGainStateMessage(bool enable)
        {
            this.enable = enable;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(enable);
            

}

public void Deserialize(IDataReader reader)
{

enable = reader.ReadBoolean();
            

}


}


}