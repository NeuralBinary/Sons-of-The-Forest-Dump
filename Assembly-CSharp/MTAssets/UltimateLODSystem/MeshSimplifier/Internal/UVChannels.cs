using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace MTAssets.UltimateLODSystem.MeshSimplifier.Internal
{
	// Token: 0x02000075 RID: 117
	[Token(Token = "0x2000075")]
	internal class UVChannels<TVec>
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600024B RID: 587 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x17000031")]
		public TVec[][] Data
		{
			[Token(Token = "0x600024B")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000032 RID: 50
		[Token(Token = "0x17000032")]
		public ResizableArray<TVec> this[int index]
		{
			[Token(Token = "0x600024C")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return null;
			}
			[Token(Token = "0x600024D")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024E")]
		public UVChannels()
		{
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024F")]
		public void Resize(int capacity, bool trimExess = false)
		{
		}

		// Token: 0x04000325 RID: 805
		[Token(Token = "0x4000325")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int UVChannelCount;

		// Token: 0x04000326 RID: 806
		[Token(Token = "0x4000326")]
		[FieldOffset(Offset = "0x0")]
		private ResizableArray<TVec>[] channels;

		// Token: 0x04000327 RID: 807
		[Token(Token = "0x4000327")]
		[FieldOffset(Offset = "0x0")]
		private TVec[][] channelsData;
	}
}
