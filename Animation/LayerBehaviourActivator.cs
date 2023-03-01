using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Sons.Animation
{
	// Token: 0x020008A6 RID: 2214
	[Token(Token = "0x20008A6")]
	public class LayerBehaviourActivator : ILayerBehaviourActivator
	{
		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06003BDA RID: 15322 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003BDB RID: 15323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000757")]
		public string DebugName
		{
			[Token(Token = "0x6003BDA")]
			[Address(RVA = "0x5430A0", Offset = "0x5420A0", VA = "0x1805430A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003BDB")]
			[Address(RVA = "0x5A85D0", Offset = "0x5A75D0", VA = "0x1805A85D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06003BDC RID: 15324 RVA: 0x00011688 File Offset: 0x0000F888
		// (set) Token: 0x06003BDD RID: 15325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000758")]
		public int Layer
		{
			[Token(Token = "0x6003BDC")]
			[Address(RVA = "0x5D9500", Offset = "0x5D8500", VA = "0x1805D9500", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6003BDD")]
			[Address(RVA = "0x64A100", Offset = "0x649100", VA = "0x18064A100")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x06003BDE RID: 15326 RVA: 0x000116A0 File Offset: 0x0000F8A0
		// (set) Token: 0x06003BDF RID: 15327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000759")]
		public bool IsActive
		{
			[Token(Token = "0x6003BDE")]
			[Address(RVA = "0x12DAAB0", Offset = "0x12D9AB0", VA = "0x1812DAAB0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003BDF")]
			[Address(RVA = "0x12EC6A0", Offset = "0x12EB6A0", VA = "0x1812EC6A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003BE0 RID: 15328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BE0")]
		[Address(RVA = "0x1F90090", Offset = "0x1F8F090", VA = "0x181F90090")]
		public LayerBehaviourActivator(string debugName, int layer, bool isActive = true)
		{
		}
	}
}
