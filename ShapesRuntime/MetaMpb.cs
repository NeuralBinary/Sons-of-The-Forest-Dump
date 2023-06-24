using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000030")]
	internal abstract class MetaMpb : IDisposable
	{
		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x000044FC File Offset: 0x000026FC
		[Token(Token = "0x17000160")]
		public bool HasContent
		{
			[Token(Token = "0x6000AA2")]
			[Address(RVA = "0x5FD4E0", Offset = "0x5FBAE0", VA = "0x1805FD4E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x00004514 File Offset: 0x00002714
		[Token(Token = "0x17000161")]
		private bool HasMultipleInstances
		{
			[Token(Token = "0x6000AA3")]
			[Address(RVA = "0x2A3A420", Offset = "0x2A38A20", VA = "0x182A3A420")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AA4")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ApplyColorOrFill<T>(T fillable, Color baseColor) where T : MetaMpb, IFillableMpb
		{
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AA5")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ApplyDashSettings<T>(T dashable, float thickness) where T : MetaMpb, IDashableMpb
		{
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000AA6")]
		internal static List<T> InitList<T>()
		{
			return null;
		}

		// Token: 0x06000AA7 RID: 2727
		[Token(Token = "0x6000AA7")]
		protected abstract void TransferShapeProperties();

		// Token: 0x06000AA8 RID: 2728 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x2A3A430", Offset = "0x2A38A30", VA = "0x182A3A430")]
		protected void Transfer(int propertyID, List<Vector4> listVec)
		{
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x2A3A660", Offset = "0x2A38C60", VA = "0x182A3A660")]
		protected void Transfer(int propertyID, List<float> listFloat)
		{
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x2A3A7D0", Offset = "0x2A38DD0", VA = "0x182A3A7D0")]
		protected void Transfer(int propertyID, List<Texture> listTex)
		{
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x0000452C File Offset: 0x0000272C
		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x2A3A920", Offset = "0x2A38F20", VA = "0x182A3A920")]
		public bool PreAppendCheck(ShapeDrawState additionDrawState, Matrix4x4 mtx)
		{
			return default(bool);
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x00004544 File Offset: 0x00002744
		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x2A3AA40", Offset = "0x2A39040", VA = "0x182A3AA40")]
		public ShapeDrawCall ExtractDrawCall()
		{
			return default(ShapeDrawCall);
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0x2A3ADE0", Offset = "0x2A393E0", VA = "0x182A3ADE0")]
		public void ApplyDirectlyToMaterial()
		{
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0x2A3AE20", Offset = "0x2A39420", VA = "0x182A3AE20")]
		internal void TransferAllProperties()
		{
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0x2A3B1F0", Offset = "0x2A397F0", VA = "0x182A3B1F0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0x2A3B210", Offset = "0x2A39810", VA = "0x182A3B210")]
		protected MetaMpb()
		{
		}

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x10")]
		private bool initialized;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x14")]
		private int instanceCount;

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x18")]
		private ShapeDrawState drawState;

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x30")]
		private Matrix4x4[] matrices;

		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x38")]
		private bool directMaterialApply;

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x40")]
		internal List<Vector4> color;

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x48")]
		private ShapeDrawCall sdc;
	}
}
