using System;
using Il2CppDummyDll;
using UdpKit;

namespace Bolt
{
	// Token: 0x02000073 RID: 115
	[Token(Token = "0x2000073")]
	internal interface IEntitySerializer
	{
		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600046D RID: 1133
		[Token(Token = "0x170000E1")]
		TypeId TypeId { [Token(Token = "0x600046D")] get; }

		// Token: 0x0600046E RID: 1134
		[Token(Token = "0x600046E")]
		void OnRender();

		// Token: 0x0600046F RID: 1135
		[Token(Token = "0x600046F")]
		void OnInitialized();

		// Token: 0x06000470 RID: 1136
		[Token(Token = "0x6000470")]
		void OnCreated(Entity entity);

		// Token: 0x06000471 RID: 1137
		[Token(Token = "0x6000471")]
		void OnParentChanging(Entity newParent, Entity oldParent);

		// Token: 0x06000472 RID: 1138
		[Token(Token = "0x6000472")]
		void OnSimulateBefore();

		// Token: 0x06000473 RID: 1139
		[Token(Token = "0x6000473")]
		void OnSimulateAfter();

		// Token: 0x06000474 RID: 1140
		[Token(Token = "0x6000474")]
		void OnControlGained();

		// Token: 0x06000475 RID: 1141
		[Token(Token = "0x6000475")]
		void OnControlLost();

		// Token: 0x06000476 RID: 1142
		[Token(Token = "0x6000476")]
		BitSet GetDefaultMask();

		// Token: 0x06000477 RID: 1143
		[Token(Token = "0x6000477")]
		BitSet GetFilter(BoltConnection connection, EntityProxy proxy);

		// Token: 0x06000478 RID: 1144
		[Token(Token = "0x6000478")]
		void DebugInfo();

		// Token: 0x06000479 RID: 1145
		[Token(Token = "0x6000479")]
		void InitProxy(EntityProxy p);

		// Token: 0x0600047A RID: 1146
		[Token(Token = "0x600047A")]
		int Pack(BoltConnection connection, UdpPacket stream, EntityProxyEnvelope proxy);

		// Token: 0x0600047B RID: 1147
		[Token(Token = "0x600047B")]
		void Read(BoltConnection connection, UdpPacket stream, int frame);
	}
}
