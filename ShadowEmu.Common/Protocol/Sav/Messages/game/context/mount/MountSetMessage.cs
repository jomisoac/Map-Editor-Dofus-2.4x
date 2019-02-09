


















// Generated on 07/24/2016 18:35:50
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class MountSetMessage : NetworkMessage
{

public const uint Id = 5968;
public uint MessageId
{
    get { return Id; }
}

public Types.MountClientData mountData;
        

public MountSetMessage()
{
}

public MountSetMessage(Types.MountClientData mountData)
        {
            this.mountData = mountData;
        }
        

public void Serialize(IDataWriter writer)
{

mountData.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

mountData = new Types.MountClientData();
            mountData.Deserialize(reader);
            

}


}


}