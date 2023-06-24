using System;
using Il2CppDummyDll;
using Sons.Items.Core;
using Sons.Save;

namespace Sons.Inventory
{
	// Token: 0x02000645 RID: 1605
	[Token(Token = "0x2000645")]
	[Serializable]
	public class WorldItemState
	{
		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06002997 RID: 10647 RVA: 0x0000C480 File Offset: 0x0000A680
		[Token(Token = "0x17000574")]
		public bool Unnamed
		{
			[Token(Token = "0x6002997")]
			[Address(RVA = "0x33EE770", Offset = "0x33ECD70", VA = "0x1833EE770")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002998 RID: 10648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002998")]
		[Address(RVA = "0x33EE790", Offset = "0x33ECD90", VA = "0x1833EE790")]
		public void GenerateName()
		{
		}

		// Token: 0x06002999 RID: 10649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002999")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public WorldItemState()
		{
		}

		// Token: 0x040024FD RID: 9469
		[Token(Token = "0x40024FD")]
		[FieldOffset(Offset = "0x10")]
		public string ObjectNameId;

		// Token: 0x040024FE RID: 9470
		[Token(Token = "0x40024FE")]
		[FieldOffset(Offset = "0x18")]
		[ItemIdPicker(true)]
		public int ItemId;

		// Token: 0x040024FF RID: 9471
		[Token(Token = "0x40024FF")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3S Position;

		// Token: 0x04002500 RID: 9472
		[Token(Token = "0x4002500")]
		[FieldOffset(Offset = "0x28")]
		public Vector3S Rotation;

		// Token: 0x04002501 RID: 9473
		[Token(Token = "0x4002501")]
		[FieldOffset(Offset = "0x34")]
		public int State;

		// Token: 0x04002502 RID: 9474
		[Token(Token = "0x4002502")]
		[FieldOffset(Offset = "0x38")]
		public bool RuntimeCreated;

		// Token: 0x04002503 RID: 9475
		[Token(Token = "0x4002503")]
		[FieldOffset(Offset = "0x40")]
		public WorldItemStateData[] ItemStateData;
	}
}
