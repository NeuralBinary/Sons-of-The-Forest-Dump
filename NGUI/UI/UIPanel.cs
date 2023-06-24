using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using NGUI.Internal;
using UnityEngine;

namespace NGUI.UI
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	[ExecuteInEditMode]
	[AddComponentMenu("NGUI/UI/NGUI Panel")]
	public class UIPanel : UIRect
	{
		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00002B20 File Offset: 0x00000D20
		[Token(Token = "0x17000074")]
		public static int nextUnusedDepth
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x2640DD0", Offset = "0x263F3D0", VA = "0x182640DD0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x00002B38 File Offset: 0x00000D38
		[Token(Token = "0x17000075")]
		public override bool canBeAnchored
		{
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x2640EF0", Offset = "0x263F4F0", VA = "0x182640EF0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00002B50 File Offset: 0x00000D50
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000076")]
		public override float alpha
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x2640F00", Offset = "0x263F500", VA = "0x182640F00", Slot = "7")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x2640F10", Offset = "0x263F510", VA = "0x182640F10", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00002B68 File Offset: 0x00000D68
		// (set) Token: 0x060001BB RID: 443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000077")]
		public int depth
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x2641010", Offset = "0x263F610", VA = "0x182641010")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x2641020", Offset = "0x263F620", VA = "0x182641020")]
			set
			{
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001BC RID: 444 RVA: 0x00002B80 File Offset: 0x00000D80
		// (set) Token: 0x060001BD RID: 445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000078")]
		public int sortingOrder
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x2641100", Offset = "0x263F700", VA = "0x182641100")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x2641110", Offset = "0x263F710", VA = "0x182641110")]
			set
			{
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00002B98 File Offset: 0x00000D98
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x2641130", Offset = "0x263F730", VA = "0x182641130")]
		public static int CompareFunc(UIPanel a, UIPanel b)
		{
			return 0;
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00002BB0 File Offset: 0x00000DB0
		[Token(Token = "0x17000079")]
		public float width
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x26413A0", Offset = "0x263F9A0", VA = "0x1826413A0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x00002BC8 File Offset: 0x00000DC8
		[Token(Token = "0x1700007A")]
		public float height
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x26413C0", Offset = "0x263F9C0", VA = "0x1826413C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x00002BE0 File Offset: 0x00000DE0
		[Token(Token = "0x1700007B")]
		public bool halfPixelOffset
		{
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x26413E0", Offset = "0x263F9E0", VA = "0x1826413E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00002BF8 File Offset: 0x00000DF8
		[Token(Token = "0x1700007C")]
		public bool usedForUI
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x26413F0", Offset = "0x263F9F0", VA = "0x1826413F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x00002C10 File Offset: 0x00000E10
		[Token(Token = "0x1700007D")]
		public Vector3 drawCallOffset
		{
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x2641520", Offset = "0x263FB20", VA = "0x182641520")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x00002C28 File Offset: 0x00000E28
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007E")]
		public UIDrawCall.Clipping clipping
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x6A4DA0", Offset = "0x6A33A0", VA = "0x1806A4DA0")]
			get
			{
				return UIDrawCall.Clipping.None;
			}
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x2641840", Offset = "0x263FE40", VA = "0x182641840")]
			set
			{
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700007F")]
		public UIPanel parentPanel
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x2641860", Offset = "0x263FE60", VA = "0x182641860")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x00002C40 File Offset: 0x00000E40
		[Token(Token = "0x17000080")]
		public int clipCount
		{
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x2641870", Offset = "0x263FE70", VA = "0x182641870")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00002C58 File Offset: 0x00000E58
		[Token(Token = "0x17000081")]
		public bool hasClipping
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x2641950", Offset = "0x263FF50", VA = "0x182641950")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x00002C70 File Offset: 0x00000E70
		[Token(Token = "0x17000082")]
		public bool hasCumulativeClipping
		{
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x2641970", Offset = "0x263FF70", VA = "0x182641970")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00002C88 File Offset: 0x00000E88
		[Token(Token = "0x17000083")]
		[Obsolete("Use 'hasClipping' or 'hasCumulativeClipping' instead")]
		public bool clipsChildren
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x2641970", Offset = "0x263FF70", VA = "0x182641970")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001CB RID: 459 RVA: 0x00002CA0 File Offset: 0x00000EA0
		// (set) Token: 0x060001CC RID: 460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000084")]
		public Vector2 clipOffset
		{
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x2641990", Offset = "0x263FF90", VA = "0x182641990")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x26419B0", Offset = "0x263FFB0", VA = "0x1826419B0")]
			set
			{
			}
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x2641A40", Offset = "0x2640040", VA = "0x182641A40")]
		private void InvalidateClipping()
		{
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060001CF RID: 463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000085")]
		public Texture2D clipTexture
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x6913C0", Offset = "0x68F9C0", VA = "0x1806913C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x2641CC0", Offset = "0x26402C0", VA = "0x182641CC0")]
			set
			{
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x00002CB8 File Offset: 0x00000EB8
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000086")]
		[Obsolete("Use 'finalClipRegion' or 'baseClipRegion' instead")]
		public Vector4 clipRange
		{
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x2641E20", Offset = "0x2640420", VA = "0x182641E20")]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x2641E30", Offset = "0x2640430", VA = "0x182641E30")]
			set
			{
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00002CD0 File Offset: 0x00000ED0
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000087")]
		public Vector4 baseClipRegion
		{
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x2641E20", Offset = "0x2640420", VA = "0x182641E20")]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x2641E50", Offset = "0x2640450", VA = "0x182641E50")]
			set
			{
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00002CE8 File Offset: 0x00000EE8
		[Token(Token = "0x17000088")]
		public Vector4 finalClipRegion
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x2641FD0", Offset = "0x26405D0", VA = "0x182641FD0")]
			get
			{
				return default(Vector4);
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00002D00 File Offset: 0x00000F00
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000089")]
		public Vector2 clipSoftness
		{
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x2642050", Offset = "0x2640650", VA = "0x182642050")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x2642070", Offset = "0x2640670", VA = "0x182642070")]
			set
			{
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700008A")]
		public override Vector3[] localCorners
		{
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x26420C0", Offset = "0x26406C0", VA = "0x1826420C0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700008B")]
		public override Vector3[] worldCorners
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x26423F0", Offset = "0x26409F0", VA = "0x1826423F0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x2642D40", Offset = "0x2641340", VA = "0x182642D40", Slot = "13")]
		public override Vector3[] GetSides(Transform relativeTo)
		{
			return null;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x2643620", Offset = "0x2641C20", VA = "0x182643620", Slot = "12")]
		public override void Invalidate(bool includeChildren)
		{
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00002D18 File Offset: 0x00000F18
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x2643640", Offset = "0x2641C40", VA = "0x182643640", Slot = "9")]
		public override float CalculateFinalAlpha(int frameID)
		{
			return 0f;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x2643780", Offset = "0x2641D80", VA = "0x182643780", Slot = "18")]
		public override void SetRect(float x, float y, float width, float height)
		{
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00002D30 File Offset: 0x00000F30
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x2643C40", Offset = "0x2642240", VA = "0x182643C40")]
		public bool IsVisible(Vector3 a, Vector3 b, Vector3 c, Vector3 d)
		{
			return default(bool);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002D48 File Offset: 0x00000F48
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x2644280", Offset = "0x2642880", VA = "0x182644280")]
		public bool IsVisible(Vector3 worldPos)
		{
			return default(bool);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00002D60 File Offset: 0x00000F60
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x2644380", Offset = "0x2642980", VA = "0x182644380")]
		public bool IsVisible(UIWidget w)
		{
			return default(bool);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00002D78 File Offset: 0x00000F78
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x2644570", Offset = "0x2642B70", VA = "0x182644570")]
		public bool Affects(UIWidget w)
		{
			return default(bool);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x26447F0", Offset = "0x2642DF0", VA = "0x1826447F0")]
		[ContextMenu("Force Refresh")]
		public void RebuildAllDrawCalls()
		{
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x2644800", Offset = "0x2642E00", VA = "0x182644800")]
		public void SetDirty()
		{
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x26448C0", Offset = "0x2642EC0", VA = "0x1826448C0")]
		private void Awake()
		{
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x2644BB0", Offset = "0x26431B0", VA = "0x182644BB0")]
		private void FindParent()
		{
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x2644DA0", Offset = "0x26433A0", VA = "0x182644DA0", Slot = "19")]
		public override void ParentHasChanged()
		{
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x2644DC0", Offset = "0x26433C0", VA = "0x182644DC0", Slot = "20")]
		protected override void OnStart()
		{
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x2644E30", Offset = "0x2643430", VA = "0x182644E30", Slot = "14")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x2644EA0", Offset = "0x26434A0", VA = "0x182644EA0", Slot = "15")]
		protected override void OnInit()
		{
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x2645370", Offset = "0x2643970", VA = "0x182645370", Slot = "16")]
		protected override void OnDisable()
		{
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x26456F0", Offset = "0x2643CF0", VA = "0x1826456F0")]
		private void UpdateTransformMatrix()
		{
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x26458A0", Offset = "0x2643EA0", VA = "0x1826458A0", Slot = "17")]
		protected override void OnAnchor()
		{
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x26464B0", Offset = "0x2644AB0", VA = "0x1826464B0")]
		private void LateUpdate()
		{
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x26467D0", Offset = "0x2644DD0", VA = "0x1826467D0")]
		private void UpdateSelf()
		{
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x2646A30", Offset = "0x2645030", VA = "0x182646A30")]
		public void SortWidgets()
		{
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x2646AD0", Offset = "0x26450D0", VA = "0x182646AD0")]
		private void FillAllDrawCalls()
		{
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00002D90 File Offset: 0x00000F90
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x2647870", Offset = "0x2645E70", VA = "0x182647870")]
		private bool FillDrawCall(UIDrawCall dc)
		{
			return default(bool);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x2647D90", Offset = "0x2646390", VA = "0x182647D90")]
		private void UpdateDrawCalls()
		{
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x2648800", Offset = "0x2646E00", VA = "0x182648800")]
		private void UpdateLayers()
		{
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x2648C30", Offset = "0x2647230", VA = "0x182648C30")]
		private void UpdateWidgets()
		{
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x2649150", Offset = "0x2647750", VA = "0x182649150")]
		public UIDrawCall FindDrawCall(UIWidget w)
		{
			return null;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x2649500", Offset = "0x2647B00", VA = "0x182649500")]
		public void AddWidget(UIWidget w)
		{
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x26496B0", Offset = "0x2647CB0", VA = "0x1826496B0")]
		public void RemoveWidget(UIWidget w)
		{
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x2649850", Offset = "0x2647E50", VA = "0x182649850")]
		public void Refresh()
		{
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00002DA8 File Offset: 0x00000FA8
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x2649950", Offset = "0x2647F50", VA = "0x182649950", Slot = "22")]
		public virtual Vector3 CalculateConstrainOffset(Vector2 min, Vector2 max)
		{
			return default(Vector3);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002DC0 File Offset: 0x00000FC0
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x2649AE0", Offset = "0x26480E0", VA = "0x182649AE0")]
		public bool ConstrainTargetToBounds(Transform target, ref Bounds targetBounds, bool immediate)
		{
			return default(bool);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00002DD8 File Offset: 0x00000FD8
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x264A0C0", Offset = "0x26486C0", VA = "0x18264A0C0")]
		public bool ConstrainTargetToBounds(Transform target, bool immediate)
		{
			return default(bool);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x264A150", Offset = "0x2648750", VA = "0x18264A150")]
		public static UIPanel Find(Transform trans)
		{
			return null;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x264A1A0", Offset = "0x26487A0", VA = "0x18264A1A0")]
		public static UIPanel Find(Transform trans, bool createIfMissing)
		{
			return null;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x264A200", Offset = "0x2648800", VA = "0x18264A200")]
		public static UIPanel Find(Transform trans, bool createIfMissing, int layer)
		{
			return null;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002DF0 File Offset: 0x00000FF0
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x264A480", Offset = "0x2648A80", VA = "0x18264A480")]
		public Vector2 GetWindowSize()
		{
			return default(Vector2);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002E08 File Offset: 0x00001008
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x264A600", Offset = "0x2648C00", VA = "0x18264A600")]
		public Vector2 GetViewSize()
		{
			return default(Vector2);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x264A670", Offset = "0x2648C70", VA = "0x18264A670")]
		public UIPanel()
		{
		}

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x0")]
		public static List<UIPanel> list;

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x98")]
		public UIPanel.OnGeometryUpdated onGeometryUpdated;

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0xA0")]
		public bool showInPanelTool;

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0xA1")]
		public bool generateNormals;

		// Token: 0x0400016A RID: 362
		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0xA2")]
		public bool widgetsAreStatic;

		// Token: 0x0400016B RID: 363
		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0xA3")]
		public bool cullWhileDragging;

		// Token: 0x0400016C RID: 364
		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0xA4")]
		public bool alwaysOnScreen;

		// Token: 0x0400016D RID: 365
		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0xA5")]
		public bool anchorOffset;

		// Token: 0x0400016E RID: 366
		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0xA6")]
		public bool softBorderPadding;

		// Token: 0x0400016F RID: 367
		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0xA8")]
		public UIPanel.RenderQueue renderQueue;

		// Token: 0x04000170 RID: 368
		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0xAC")]
		public int startingRenderQueue;

		// Token: 0x04000171 RID: 369
		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0xB0")]
		[NonSerialized]
		public List<UIWidget> widgets;

		// Token: 0x04000172 RID: 370
		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0xB8")]
		[NonSerialized]
		public List<UIDrawCall> drawCalls;

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0xC0")]
		[NonSerialized]
		public Matrix4x4 worldToLocal;

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x100")]
		[NonSerialized]
		public Vector4 drawCallClipRange;

		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x110")]
		public UIPanel.OnClippingMoved onClipMove;

		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x118")]
		[HideInInspector]
		[SerializeField]
		private Texture2D mClipTexture;

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x120")]
		[HideInInspector]
		[SerializeField]
		private float mAlpha;

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x124")]
		[SerializeField]
		[HideInInspector]
		private UIDrawCall.Clipping mClipping;

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x128")]
		[HideInInspector]
		[SerializeField]
		private Vector4 mClipRange;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		[HideInInspector]
		private Vector2 mClipSoftness;

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		[HideInInspector]
		private int mDepth;

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x144")]
		[SerializeField]
		[HideInInspector]
		private int mSortingOrder;

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x148")]
		private bool mRebuild;

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x149")]
		private bool mResized;

		// Token: 0x0400017F RID: 383
		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x14C")]
		[SerializeField]
		private Vector2 mClipOffset;

		// Token: 0x04000180 RID: 384
		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x154")]
		private int mMatrixFrame;

		// Token: 0x04000181 RID: 385
		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x158")]
		private int mAlphaFrameID;

		// Token: 0x04000182 RID: 386
		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x15C")]
		private int mLayer;

		// Token: 0x04000183 RID: 387
		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x8")]
		private static float[] mTemp;

		// Token: 0x04000184 RID: 388
		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x160")]
		private Vector2 mMin;

		// Token: 0x04000185 RID: 389
		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x168")]
		private Vector2 mMax;

		// Token: 0x04000186 RID: 390
		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x170")]
		private bool mHalfPixelOffset;

		// Token: 0x04000187 RID: 391
		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x171")]
		private bool mSortWidgets;

		// Token: 0x04000188 RID: 392
		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x172")]
		private bool mUpdateScroll;

		// Token: 0x04000189 RID: 393
		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x178")]
		private UIPanel mParentPanel;

		// Token: 0x0400018A RID: 394
		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x10")]
		private static Vector3[] mCorners;

		// Token: 0x0400018B RID: 395
		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x18")]
		private static int mUpdateFrame;

		// Token: 0x0400018C RID: 396
		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x180")]
		private UIDrawCall.OnRenderCallback mOnRender;

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x188")]
		private bool mForced;

		// Token: 0x02000035 RID: 53
		[Token(Token = "0x2000035")]
		public enum RenderQueue
		{
			// Token: 0x0400018F RID: 399
			[Token(Token = "0x400018F")]
			Automatic,
			// Token: 0x04000190 RID: 400
			[Token(Token = "0x4000190")]
			StartAt,
			// Token: 0x04000191 RID: 401
			[Token(Token = "0x4000191")]
			Explicit
		}

		// Token: 0x02000036 RID: 54
		// (Invoke) Token: 0x06000203 RID: 515
		[Token(Token = "0x2000036")]
		public delegate void OnGeometryUpdated();

		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x06000207 RID: 519
		[Token(Token = "0x2000037")]
		public delegate void OnClippingMoved(UIPanel panel);
	}
}
