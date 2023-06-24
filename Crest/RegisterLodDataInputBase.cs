using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Crest
{
	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200004B")]
	[ExecuteAlways]
	public abstract class RegisterLodDataInputBase : MonoBehaviour, ILodDataInput
	{
		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001BE RID: 446
		[Token(Token = "0x17000066")]
		public abstract float Wavelength { [Token(Token = "0x60001BE")] get; }

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001BF RID: 447
		[Token(Token = "0x17000067")]
		public abstract bool Enabled { [Token(Token = "0x60001BF")] get; }

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x00002B38 File Offset: 0x00000D38
		[Token(Token = "0x17000068")]
		protected virtual bool FollowHorizontalMotion
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001C1 RID: 449
		[Token(Token = "0x17000069")]
		protected abstract string ShaderPrefix { [Token(Token = "0x60001C1")] get; }

		// Token: 0x060001C2 RID: 450 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x9F93C0", Offset = "0x9F79C0", VA = "0x1809F93C0")]
		public static CrestSortedList<int, ILodDataInput> GetRegistrar(Type lodDataMgrType)
		{
			return null;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x9F9530", Offset = "0x9F7B30", VA = "0x1809F9530")]
		private void InitRendererAndMaterial(bool verifyShader)
		{
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x9F9730", Offset = "0x9F7D30", VA = "0x1809F9730")]
		protected void Start()
		{
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "11")]
		protected virtual void Update()
		{
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x9F9740", Offset = "0x9F7D40", VA = "0x1809F9740", Slot = "12")]
		public virtual void Draw(CommandBuffer buf, float weight, int isTransition, int lodIdx)
		{
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x9F9C20", Offset = "0x9F8220", VA = "0x1809F9C20")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void InitStatics()
		{
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x9F9D00", Offset = "0x9F8300", VA = "0x1809F9D00")]
		protected RegisterLodDataInputBase()
		{
		}

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x0")]
		public static int sp_Weight;

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x4")]
		public static int sp_DisplacementAtInputPosition;

		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x8")]
		private static DuplicateKeyComparer<int> s_comparer;

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x10")]
		private static Dictionary<Type, CrestSortedList<int, ILodDataInput>> s_registrar;

		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x20")]
		protected Renderer _renderer;

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x28")]
		protected Material _material;

		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x30")]
		private SampleHeightHelper _sampleHelper;
	}
}
