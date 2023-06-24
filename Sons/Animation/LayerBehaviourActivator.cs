using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Sons.Animation
{
	// Token: 0x02000918 RID: 2328
	[Token(Token = "0x2000918")]
	public class LayerBehaviourActivator : ILayerBehaviourActivator
	{
		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x0600430B RID: 17163 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600430C RID: 17164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700087C")]
		public string DebugName
		{
			[Token(Token = "0x600430B")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600430C")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x0600430D RID: 17165 RVA: 0x00014520 File Offset: 0x00012720
		// (set) Token: 0x0600430E RID: 17166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700087D")]
		public int Layer
		{
			[Token(Token = "0x600430D")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600430E")]
			[Address(RVA = "0x6DDE70", Offset = "0x6DC470", VA = "0x1806DDE70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x0600430F RID: 17167 RVA: 0x00014538 File Offset: 0x00012738
		// (set) Token: 0x06004310 RID: 17168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700087E")]
		public bool IsActive
		{
			[Token(Token = "0x600430F")]
			[Address(RVA = "0x150B770", Offset = "0x1509D70", VA = "0x18150B770", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004310")]
			[Address(RVA = "0x1522030", Offset = "0x1520630", VA = "0x181522030")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004311 RID: 17169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004311")]
		[Address(RVA = "0x2332D30", Offset = "0x2331330", VA = "0x182332D30")]
		public LayerBehaviourActivator(string debugName, int layer, bool isActive = true)
		{
		}
	}
}
