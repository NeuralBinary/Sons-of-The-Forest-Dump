using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Sons.Inventory
{
	// Token: 0x02000649 RID: 1609
	[Token(Token = "0x2000649")]
	[JsonConverter(typeof(WorldItemStateDataJsonConverter))]
	[Serializable]
	public abstract class WorldItemStateData
	{
		// Token: 0x060029AB RID: 10667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029AB")]
		[Address(RVA = "0x33EFB30", Offset = "0x33EE130", VA = "0x1833EFB30")]
		protected WorldItemStateData()
		{
		}

		// Token: 0x04002512 RID: 9490
		[Token(Token = "0x4002512")]
		[FieldOffset(Offset = "0x10")]
		public string Version;

		// Token: 0x04002513 RID: 9491
		[Token(Token = "0x4002513")]
		[FieldOffset(Offset = "0x18")]
		public int StateDataTypeId;
	}
}
