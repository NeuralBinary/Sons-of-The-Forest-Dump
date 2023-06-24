using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Shapes
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	[DisallowMultipleComponent]
	public abstract class ShapeRenderer : MonoBehaviour
	{
		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x170000B0")]
		private MaterialPropertyBlock Mpb
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x2A2C6F0", Offset = "0x2A2ACF0", VA = "0x182A2C6F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060001AA RID: 426 RVA: 0x000032E4 File Offset: 0x000014E4
		[Token(Token = "0x170000B1")]
		internal bool IsUsingUniqueMaterials
		{
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x2A2C7D0", Offset = "0x2A2ADD0", VA = "0x182A2C7D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060001AB RID: 427 RVA: 0x0000210E File Offset: 0x0000030E
		// (set) Token: 0x060001AC RID: 428 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000B2")]
		public Mesh Mesh
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x2A2C830", Offset = "0x2A2AE30", VA = "0x182A2C830")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x2A2C890", Offset = "0x2A2AE90", VA = "0x182A2C890")]
			private set
			{
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060001AD RID: 429 RVA: 0x000032FC File Offset: 0x000014FC
		// (set) Token: 0x060001AE RID: 430 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000B3")]
		public int SortingLayerID
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x2A2C900", Offset = "0x2A2AF00", VA = "0x182A2C900")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x2A2C9A0", Offset = "0x2A2AFA0", VA = "0x182A2C9A0")]
			set
			{
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00003314 File Offset: 0x00001514
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000B4")]
		public int SortingOrder
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x2A2CA50", Offset = "0x2A2B050", VA = "0x182A2CA50")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x2A2CAF0", Offset = "0x2A2B0F0", VA = "0x182A2CAF0")]
			set
			{
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x170000B5")]
		public string SortingLayerName
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x2A2CBA0", Offset = "0x2A2B1A0", VA = "0x182A2CBA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x0000332C File Offset: 0x0000152C
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000B6")]
		public ShapesBlendMode BlendMode
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x6FF7C0", Offset = "0x6FDDC0", VA = "0x1806FF7C0")]
			get
			{
				return ShapesBlendMode.Opaque;
			}
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x2A2CC80", Offset = "0x2A2B280", VA = "0x182A2CC80")]
			set
			{
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00003344 File Offset: 0x00001544
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000B7")]
		public ScaleMode ScaleMode
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x8F47A0", Offset = "0x8F2DA0", VA = "0x1808F47A0")]
			get
			{
				return ScaleMode.Uniform;
			}
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x2A2CC90", Offset = "0x2A2B290", VA = "0x182A2CC90")]
			set
			{
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x0000335C File Offset: 0x0000155C
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000B8")]
		public virtual Color Color
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x2A204E0", Offset = "0x2A1EAE0", VA = "0x182A204E0", Slot = "4")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x2A2CD30", Offset = "0x2A2B330", VA = "0x182A2CD30", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00003374 File Offset: 0x00001574
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000B9")]
		public virtual DetailLevel DetailLevel
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x671130", Offset = "0x66F730", VA = "0x180671130", Slot = "6")]
			get
			{
				return DetailLevel.Minimal;
			}
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x2A2CDC0", Offset = "0x2A2B3C0", VA = "0x182A2CDC0", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060001BA RID: 442 RVA: 0x0000338C File Offset: 0x0000158C
		[Token(Token = "0x170000BA")]
		private bool IsInstanced
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x2A2CDD0", Offset = "0x2A2B3D0", VA = "0x182A2CDD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060001BB RID: 443 RVA: 0x000033A4 File Offset: 0x000015A4
		[Token(Token = "0x170000BB")]
		private bool UsingDefaultRenderQueue
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x2A2CE30", Offset = "0x2A2B430", VA = "0x182A2CE30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060001BC RID: 444 RVA: 0x000033BC File Offset: 0x000015BC
		// (set) Token: 0x060001BD RID: 445 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000BC")]
		public int RenderQueue
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x8DCFC0", Offset = "0x8DB5C0", VA = "0x1808DCFC0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x2A2CE40", Offset = "0x2A2B440", VA = "0x182A2CE40")]
			set
			{
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060001BE RID: 446 RVA: 0x000033D4 File Offset: 0x000015D4
		[Token(Token = "0x170000BD")]
		private bool UsingDefaultZTests
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x2A2CF60", Offset = "0x2A2B560", VA = "0x182A2CF60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060001BF RID: 447 RVA: 0x000033EC File Offset: 0x000015EC
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000BE")]
		public CompareFunction ZTest
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0xAFDBB0", Offset = "0xAFC1B0", VA = "0x180AFDBB0")]
			get
			{
				return CompareFunction.Disabled;
			}
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x2A2CF80", Offset = "0x2A2B580", VA = "0x182A2CF80")]
			set
			{
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x00003404 File Offset: 0x00001604
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000BF")]
		public float ZOffsetFactor
		{
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x23C2640", Offset = "0x23C0C40", VA = "0x1823C2640")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x2A2CFF0", Offset = "0x2A2B5F0", VA = "0x182A2CFF0")]
			set
			{
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x0000341C File Offset: 0x0000161C
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000C0")]
		public int ZOffsetUnits
		{
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0xAFF280", Offset = "0xAFD880", VA = "0x180AFF280")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x2A2D150", Offset = "0x2A2B750", VA = "0x182A2D150")]
			set
			{
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x00003434 File Offset: 0x00001634
		[Token(Token = "0x170000C1")]
		private bool UsingDefaultStencil
		{
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x2A2D1C0", Offset = "0x2A2B7C0", VA = "0x182A2D1C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x0000344C File Offset: 0x0000164C
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000C2")]
		public CompareFunction StencilComp
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0xAFF2A0", Offset = "0xAFD8A0", VA = "0x180AFF2A0")]
			get
			{
				return CompareFunction.Disabled;
			}
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x2A2D200", Offset = "0x2A2B800", VA = "0x182A2D200")]
			set
			{
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00003464 File Offset: 0x00001664
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000C3")]
		public StencilOp StencilOpPass
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0xAFF2B0", Offset = "0xAFD8B0", VA = "0x180AFF2B0")]
			get
			{
				return StencilOp.Keep;
			}
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x2A2D280", Offset = "0x2A2B880", VA = "0x182A2D280")]
			set
			{
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060001CA RID: 458 RVA: 0x0000347C File Offset: 0x0000167C
		// (set) Token: 0x060001CB RID: 459 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000C4")]
		public byte StencilRefID
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x179C600", Offset = "0x179AC00", VA = "0x18179C600")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x2A2D300", Offset = "0x2A2B900", VA = "0x182A2D300")]
			set
			{
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060001CC RID: 460 RVA: 0x00003494 File Offset: 0x00001694
		// (set) Token: 0x060001CD RID: 461 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000C5")]
		public byte StencilReadMask
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x179C620", Offset = "0x179AC20", VA = "0x18179C620")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x2A2D380", Offset = "0x2A2B980", VA = "0x182A2D380")]
			set
			{
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060001CE RID: 462 RVA: 0x000034AC File Offset: 0x000016AC
		// (set) Token: 0x060001CF RID: 463 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000C6")]
		public byte StencilWriteMask
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x2A2D400", Offset = "0x2A2BA00", VA = "0x182A2D400")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x2A2D410", Offset = "0x2A2BA10", VA = "0x182A2D410")]
			set
			{
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x60001D0")]
		private T MakeSureComponentExists<T>(ref T field, out bool created) where T : Component
		{
			return null;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x2A2D490", Offset = "0x2A2BA90", VA = "0x182A2D490")]
		private void VerifyComponents()
		{
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x2A2D580", Offset = "0x2A2BB80", VA = "0x182A2D580", Slot = "8")]
		public virtual void Awake()
		{
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x000034C4 File Offset: 0x000016C4
		[Token(Token = "0x170000C7")]
		private bool HasGeneratedOrCopyOfMesh
		{
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x2A2D5C0", Offset = "0x2A2BBC0", VA = "0x182A2D5C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x2A2D610", Offset = "0x2A2BC10", VA = "0x182A2D610", Slot = "9")]
		public virtual void OnEnable()
		{
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x2A2D6B0", Offset = "0x2A2BCB0", VA = "0x182A2D6B0")]
		private void OnDisable()
		{
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x673AB0", Offset = "0x6720B0", VA = "0x180673AB0")]
		private void OnPreCamCullWithCam(Camera cam)
		{
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x673AB0", Offset = "0x6720B0", VA = "0x180673AB0")]
		private void OnPreCamCullWithCam(ScriptableRenderContext ctx, Camera cam)
		{
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x2A2D7E0", Offset = "0x2A2BDE0", VA = "0x182A2D7E0")]
		private void SubscribeCamPreCull()
		{
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x2A2D9D0", Offset = "0x2A2BFD0", VA = "0x182A2D9D0")]
		private void UnsubscribeCamPreCull()
		{
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x2A2DBC0", Offset = "0x2A2C1C0", VA = "0x182A2DBC0")]
		private void Reset()
		{
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x2A2DBF0", Offset = "0x2A2C1F0", VA = "0x182A2DBF0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060001DC RID: 476
		[Token(Token = "0x60001DC")]
		private protected abstract Bounds GetBounds_Internal();

		// Token: 0x060001DD RID: 477
		[Token(Token = "0x60001DD")]
		private protected abstract void SetAllMaterialProperties();

		// Token: 0x060001DE RID: 478 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "12")]
		private protected virtual void ShapeClampRanges()
		{
		}

		// Token: 0x060001DF RID: 479
		[Token(Token = "0x60001DF")]
		private protected abstract Material[] GetMaterials();

		// Token: 0x060001E0 RID: 480 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "14")]
		private protected virtual void GenerateMesh()
		{
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x2A2DDA0", Offset = "0x2A2C3A0", VA = "0x182A2DDA0", Slot = "15")]
		private protected virtual Mesh GetInitialMeshAsset()
		{
			return null;
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x000034DC File Offset: 0x000016DC
		[Token(Token = "0x170000C8")]
		private protected virtual MeshUpdateMode MeshUpdateMode
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "16")]
			get
			{
				return MeshUpdateMode.UseAsset;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x000034F4 File Offset: 0x000016F4
		[Token(Token = "0x170000C9")]
		internal virtual bool HasScaleModes
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x0000350C File Offset: 0x0000170C
		[Token(Token = "0x170000CA")]
		internal virtual bool HasDetailLevels
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x00003524 File Offset: 0x00001724
		[Token(Token = "0x170000CB")]
		private protected virtual bool UseCamOnPreCull
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "20")]
		internal virtual void CamOnPreCull()
		{
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x2A2DE10", Offset = "0x2A2C410", VA = "0x182A2DE10")]
		private void UpdateMeshBounds()
		{
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x2A2DF00", Offset = "0x2A2C500", VA = "0x182A2DF00")]
		private void TryDestroyInstancedMaterials(bool inOnDestroy = false)
		{
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x2A2E080", Offset = "0x2A2C680", VA = "0x182A2E080")]
		private void MakeSureMaterialInstancesAreGood(Material[] sourceMats)
		{
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x2A2E540", Offset = "0x2A2CB40", VA = "0x182A2E540")]
		private protected void UpdateMaterial()
		{
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x2A2E630", Offset = "0x2A2CC30", VA = "0x182A2E630")]
		public void UpdateMesh(bool force = false)
		{
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000353C File Offset: 0x0000173C
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x2A2EB20", Offset = "0x2A2D120", VA = "0x182A2EB20")]
		public Bounds GetBounds()
		{
			return default(Bounds);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00003554 File Offset: 0x00001754
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x2A2EB60", Offset = "0x2A2D160", VA = "0x182A2EB60")]
		public Bounds GetWorldBounds()
		{
			return default(Bounds);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x2A2F030", Offset = "0x2A2D630", VA = "0x182A2F030")]
		private void OnDidApplyAnimationProperties()
		{
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x2A2F040", Offset = "0x2A2D640", VA = "0x182A2F040")]
		private void SetIntOnAllInstancedMaterials(int property, int value)
		{
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x2A2F160", Offset = "0x2A2D760", VA = "0x182A2F160")]
		private void SetFloatOnAllInstancedMaterials(int property, float value)
		{
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x2A2F270", Offset = "0x2A2D870", VA = "0x182A2F270")]
		internal void UpdateAllMaterialProperties()
		{
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x2A2F8F0", Offset = "0x2A2DEF0", VA = "0x182A2F8F0")]
		private protected void ApplyProperties()
		{
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x2A2FA70", Offset = "0x2A2E070", VA = "0x182A2FA70")]
		private protected void SetAllDashValues(DashStyle style, bool dashed, bool matchSpacingToSize, float thickness, bool setType, bool now)
		{
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000356C File Offset: 0x0000176C
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x2A2FD70", Offset = "0x2A2E370", VA = "0x182A2FD70")]
		private protected float GetNetDashSpacing(DashStyle style, bool dashed, bool matchSpacingToSize, float thickness)
		{
			return 0f;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x2A2FDD0", Offset = "0x2A2E3D0", VA = "0x182A2FDD0")]
		private protected void SetColor(int prop, Color value)
		{
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x2A301D0", Offset = "0x2A2E7D0", VA = "0x182A301D0")]
		private protected void SetFloat(int prop, float value)
		{
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x2A30250", Offset = "0x2A2E850", VA = "0x182A30250")]
		private protected void SetInt(int prop, int value)
		{
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x2A30290", Offset = "0x2A2E890", VA = "0x182A30290")]
		private protected void SetVector3(int prop, Vector3 value)
		{
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x2A30350", Offset = "0x2A2E950", VA = "0x182A30350")]
		private protected void SetVector4(int prop, Vector4 value)
		{
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x2A303E0", Offset = "0x2A2E9E0", VA = "0x182A303E0")]
		private protected void SetColorNow(int prop, Color value)
		{
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x2A30410", Offset = "0x2A2EA10", VA = "0x182A30410")]
		private protected void SetFloatNow(int prop, float value)
		{
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x2A304B0", Offset = "0x2A2EAB0", VA = "0x182A304B0")]
		private protected void SetIntNow(int prop, int value)
		{
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x2A30510", Offset = "0x2A2EB10", VA = "0x182A30510")]
		private protected void SetVector3Now(int prop, Vector3 value)
		{
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x2A305F0", Offset = "0x2A2EBF0", VA = "0x182A305F0")]
		private protected void SetVector4Now(int prop, Vector4 value)
		{
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x2A30690", Offset = "0x2A2EC90", VA = "0x182A30690")]
		protected ShapeRenderer()
		{
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x2A30710", Offset = "0x2A2ED10", VA = "0x182A30710")]
		[CompilerGenerated]
		private Material <MakeSureMaterialInstancesAreGood>g__InstantiateMaterial|120_0(int index, ref ShapeRenderer.<>c__DisplayClass120_0 A_2)
		{
			return null;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x2A30810", Offset = "0x2A2EE10", VA = "0x182A30810")]
		[CompilerGenerated]
		private void <MakeSureMaterialInstancesAreGood>g__PopulateAll|120_1(ref ShapeRenderer.<>c__DisplayClass120_0 A_1)
		{
		}

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x20")]
		private bool initializedComponents;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x28")]
		private MeshRenderer rnd;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x30")]
		private MeshFilter mf;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x38")]
		private int meshOwnerID;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x40")]
		private MaterialPropertyBlock mpb;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x48")]
		private Material[] instancedMaterials;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public bool meshOutOfDate;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private ShapesBlendMode blendMode;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ScaleMode scaleMode;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x5C")]
		[ShapesColorField(true)]
		[SerializeField]
		private protected Color color;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private protected DetailLevel detailLevel;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private int renderQueue;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		public const int DEFAULT_RENDER_QUEUE_AUTO = -1;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		public const CompareFunction DEFAULT_ZTEST = CompareFunction.LessEqual;

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		public const float DEFAULT_ZOFS_FACTOR = 0f;

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		public const int DEFAULT_ZOFS_UNITS = 0;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private CompareFunction zTest;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float zOffsetFactor;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private int zOffsetUnits;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		public const CompareFunction DEFAULT_STENCIL_COMP = CompareFunction.Always;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		public const StencilOp DEFAULT_STENCIL_OP = StencilOp.Keep;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		public const byte DEFAULT_STENCIL_REF_ID = 0;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		public const byte DEFAULT_STENCIL_MASK = 255;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CompareFunction stencilComp;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private StencilOp stencilOpPass;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private byte stencilRefID;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x89")]
		[SerializeField]
		private byte stencilReadMask;

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x8A")]
		[SerializeField]
		private byte stencilWriteMask;
	}
}
