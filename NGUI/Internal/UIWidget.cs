using System;
using System.Diagnostics;
using Il2CppDummyDll;
using NGUI.UI;
using UnityEngine;

namespace NGUI.Internal
{
	// Token: 0x02000090 RID: 144
	[Token(Token = "0x2000090")]
	[AddComponentMenu("NGUI/UI/NGUI Widget")]
	[ExecuteInEditMode]
	public class UIWidget : UIRect
	{
		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600057C RID: 1404 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600057D RID: 1405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000127")]
		public UIDrawCall.OnRenderCallback onRender
		{
			[Token(Token = "0x600057C")]
			[Address(RVA = "0x7849C0", Offset = "0x782FC0", VA = "0x1807849C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600057D")]
			[Address(RVA = "0x26A0320", Offset = "0x269E920", VA = "0x1826A0320")]
			set
			{
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x000041B8 File Offset: 0x000023B8
		// (set) Token: 0x0600057F RID: 1407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000128")]
		public Vector4 drawRegion
		{
			[Token(Token = "0x600057E")]
			[Address(RVA = "0x26A0670", Offset = "0x269EC70", VA = "0x1826A0670")]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x600057F")]
			[Address(RVA = "0x26A0680", Offset = "0x269EC80", VA = "0x1826A0680")]
			set
			{
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x000041D0 File Offset: 0x000023D0
		[Token(Token = "0x17000129")]
		public Vector2 pivotOffset
		{
			[Token(Token = "0x6000580")]
			[Address(RVA = "0x26A0730", Offset = "0x269ED30", VA = "0x1826A0730")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x000041E8 File Offset: 0x000023E8
		// (set) Token: 0x06000582 RID: 1410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012A")]
		public int width
		{
			[Token(Token = "0x6000581")]
			[Address(RVA = "0x7283B0", Offset = "0x7269B0", VA = "0x1807283B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000582")]
			[Address(RVA = "0x26A0740", Offset = "0x269ED40", VA = "0x1826A0740")]
			set
			{
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x00004200 File Offset: 0x00002400
		// (set) Token: 0x06000584 RID: 1412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012B")]
		public int height
		{
			[Token(Token = "0x6000583")]
			[Address(RVA = "0x7283D0", Offset = "0x7269D0", VA = "0x1807283D0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000584")]
			[Address(RVA = "0x26A0AF0", Offset = "0x269F0F0", VA = "0x1826A0AF0")]
			set
			{
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x00004218 File Offset: 0x00002418
		// (set) Token: 0x06000586 RID: 1414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012C")]
		public Color color
		{
			[Token(Token = "0x6000585")]
			[Address(RVA = "0x179CE30", Offset = "0x179B430", VA = "0x18179CE30")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000586")]
			[Address(RVA = "0x26A0E90", Offset = "0x269F490", VA = "0x1826A0E90")]
			set
			{
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x00004230 File Offset: 0x00002430
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012D")]
		public override float alpha
		{
			[Token(Token = "0x6000587")]
			[Address(RVA = "0x2403F10", Offset = "0x2402510", VA = "0x182403F10", Slot = "7")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000588")]
			[Address(RVA = "0x26A0F30", Offset = "0x269F530", VA = "0x1826A0F30", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x00004248 File Offset: 0x00002448
		[Token(Token = "0x1700012E")]
		public bool isVisible
		{
			[Token(Token = "0x6000589")]
			[Address(RVA = "0x26A0F60", Offset = "0x269F560", VA = "0x1826A0F60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x00004260 File Offset: 0x00002460
		[Token(Token = "0x1700012F")]
		public bool hasVertices
		{
			[Token(Token = "0x600058A")]
			[Address(RVA = "0x26A0FE0", Offset = "0x269F5E0", VA = "0x1826A0FE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x00004278 File Offset: 0x00002478
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000130")]
		public UIWidget.Pivot rawPivot
		{
			[Token(Token = "0x600058B")]
			[Address(RVA = "0x728390", Offset = "0x726990", VA = "0x180728390")]
			get
			{
				return UIWidget.Pivot.TopLeft;
			}
			[Token(Token = "0x600058C")]
			[Address(RVA = "0x26A1010", Offset = "0x269F610", VA = "0x1826A1010")]
			set
			{
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x00004290 File Offset: 0x00002490
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000131")]
		public UIWidget.Pivot pivot
		{
			[Token(Token = "0x600058D")]
			[Address(RVA = "0x728390", Offset = "0x726990", VA = "0x180728390")]
			get
			{
				return UIWidget.Pivot.TopLeft;
			}
			[Token(Token = "0x600058E")]
			[Address(RVA = "0x26A1060", Offset = "0x269F660", VA = "0x1826A1060")]
			set
			{
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x000042A8 File Offset: 0x000024A8
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000132")]
		public int depth
		{
			[Token(Token = "0x600058F")]
			[Address(RVA = "0xAFF380", Offset = "0xAFD980", VA = "0x180AFF380")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x26A1380", Offset = "0x269F980", VA = "0x1826A1380")]
			set
			{
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x000042C0 File Offset: 0x000024C0
		[Token(Token = "0x17000133")]
		public int raycastDepth
		{
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x26A15C0", Offset = "0x269FBC0", VA = "0x1826A15C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000134")]
		public override Vector3[] localCorners
		{
			[Token(Token = "0x6000592")]
			[Address(RVA = "0x26A1750", Offset = "0x269FD50", VA = "0x1826A1750", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x000042D8 File Offset: 0x000024D8
		[Token(Token = "0x17000135")]
		public virtual Vector2 localSize
		{
			[Token(Token = "0x6000593")]
			[Address(RVA = "0x26A18C0", Offset = "0x269FEC0", VA = "0x1826A18C0", Slot = "22")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x000042F0 File Offset: 0x000024F0
		[Token(Token = "0x17000136")]
		public Vector3 localCenter
		{
			[Token(Token = "0x6000594")]
			[Address(RVA = "0x26A1920", Offset = "0x269FF20", VA = "0x1826A1920")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000137")]
		public override Vector3[] worldCorners
		{
			[Token(Token = "0x6000595")]
			[Address(RVA = "0x26A19F0", Offset = "0x269FFF0", VA = "0x1826A19F0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x00004308 File Offset: 0x00002508
		[Token(Token = "0x17000138")]
		public Vector3 worldCenter
		{
			[Token(Token = "0x6000596")]
			[Address(RVA = "0x26A1D30", Offset = "0x26A0330", VA = "0x1826A1D30")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x00004320 File Offset: 0x00002520
		[Token(Token = "0x17000139")]
		public virtual Vector4 drawingDimensions
		{
			[Token(Token = "0x6000597")]
			[Address(RVA = "0x26A1EA0", Offset = "0x26A04A0", VA = "0x1826A1EA0", Slot = "23")]
			get
			{
				return default(Vector4);
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000599 RID: 1433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700013A")]
		public virtual Material material
		{
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000599")]
			[Address(RVA = "0x26A2020", Offset = "0x26A0620", VA = "0x1826A2020", Slot = "25")]
			set
			{
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600059B RID: 1435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700013B")]
		public virtual Texture mainTexture
		{
			[Token(Token = "0x600059A")]
			[Address(RVA = "0x26A20B0", Offset = "0x26A06B0", VA = "0x1826A20B0", Slot = "26")]
			get
			{
				return null;
			}
			[Token(Token = "0x600059B")]
			[Address(RVA = "0x26A2190", Offset = "0x26A0790", VA = "0x1826A2190", Slot = "27")]
			set
			{
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600059D RID: 1437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700013C")]
		public virtual Shader shader
		{
			[Token(Token = "0x600059C")]
			[Address(RVA = "0x26A2220", Offset = "0x26A0820", VA = "0x1826A2220", Slot = "28")]
			get
			{
				return null;
			}
			[Token(Token = "0x600059D")]
			[Address(RVA = "0x26A2330", Offset = "0x26A0930", VA = "0x1826A2330", Slot = "29")]
			set
			{
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x00004338 File Offset: 0x00002538
		[Token(Token = "0x1700013D")]
		[Obsolete("There is no relative scale anymore. Widgets now have width and height instead")]
		public Vector2 relativeSize
		{
			[Token(Token = "0x600059E")]
			[Address(RVA = "0x5BC600", Offset = "0x5BAC00", VA = "0x1805BC600")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x00004350 File Offset: 0x00002550
		[Token(Token = "0x1700013E")]
		public bool hasBoxCollider
		{
			[Token(Token = "0x600059F")]
			[Address(RVA = "0x26A23C0", Offset = "0x26A09C0", VA = "0x1826A23C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x26A25B0", Offset = "0x26A0BB0", VA = "0x1826A25B0")]
		public void SetDimensions(int w, int h)
		{
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x26A2680", Offset = "0x26A0C80", VA = "0x1826A2680", Slot = "13")]
		public override Vector3[] GetSides(Transform relativeTo)
		{
			return null;
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00004368 File Offset: 0x00002568
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x26A2B70", Offset = "0x26A1170", VA = "0x1826A2B70", Slot = "9")]
		public override float CalculateFinalAlpha(int frameID)
		{
			return 0f;
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x26A2BB0", Offset = "0x26A11B0", VA = "0x1826A2BB0")]
		protected void UpdateFinalAlpha(int frameID)
		{
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x26A2D00", Offset = "0x26A1300", VA = "0x1826A2D00", Slot = "12")]
		public override void Invalidate(bool includeChildren)
		{
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00004380 File Offset: 0x00002580
		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x26A2F70", Offset = "0x26A1570", VA = "0x1826A2F70")]
		public float CalculateCumulativeAlpha(int frameID)
		{
			return 0f;
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x26A3080", Offset = "0x26A1680", VA = "0x1826A3080", Slot = "18")]
		public override void SetRect(float x, float y, float width, float height)
		{
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x26A36E0", Offset = "0x26A1CE0", VA = "0x1826A36E0")]
		public void ResizeCollider()
		{
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00004398 File Offset: 0x00002598
		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x26A37D0", Offset = "0x26A1DD0", VA = "0x1826A37D0")]
		[DebuggerStepThrough]
		[DebuggerHidden]
		public static int FullCompareFunc(UIWidget left, UIWidget right)
		{
			return 0;
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x000043B0 File Offset: 0x000025B0
		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x26A3870", Offset = "0x26A1E70", VA = "0x1826A3870")]
		[DebuggerStepThrough]
		[DebuggerHidden]
		public static int PanelCompareFunc(UIWidget left, UIWidget right)
		{
			return 0;
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x000043C8 File Offset: 0x000025C8
		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x26A3B30", Offset = "0x26A2130", VA = "0x1826A3B30")]
		public Bounds CalculateBounds()
		{
			return default(Bounds);
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x000043E0 File Offset: 0x000025E0
		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x26A3B70", Offset = "0x26A2170", VA = "0x1826A3B70")]
		public Bounds CalculateBounds(Transform relativeParent)
		{
			return default(Bounds);
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x26A42D0", Offset = "0x26A28D0", VA = "0x1826A42D0")]
		public void SetDirty()
		{
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x26A43F0", Offset = "0x26A29F0", VA = "0x1826A43F0")]
		public void RemoveFromPanel()
		{
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x26A4590", Offset = "0x26A2B90", VA = "0x1826A4590", Slot = "30")]
		public virtual void MarkAsChanged()
		{
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x26A4820", Offset = "0x26A2E20", VA = "0x1826A4820")]
		public UIPanel CreatePanel()
		{
			return null;
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x26A4AD0", Offset = "0x26A30D0", VA = "0x1826A4AD0")]
		public void CheckLayer()
		{
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x26A4E20", Offset = "0x26A3420", VA = "0x1826A4E20", Slot = "19")]
		public override void ParentHasChanged()
		{
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x26A5080", Offset = "0x26A3680", VA = "0x1826A5080", Slot = "31")]
		protected virtual void Awake()
		{
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x26A51A0", Offset = "0x26A37A0", VA = "0x1826A51A0", Slot = "15")]
		protected override void OnInit()
		{
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x26A5340", Offset = "0x26A3940", VA = "0x1826A5340", Slot = "32")]
		protected virtual void UpgradeFrom265()
		{
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x26A54E0", Offset = "0x26A3AE0", VA = "0x1826A54E0", Slot = "20")]
		protected override void OnStart()
		{
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x26A54F0", Offset = "0x26A3AF0", VA = "0x1826A54F0", Slot = "17")]
		protected override void OnAnchor()
		{
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x26A6350", Offset = "0x26A4950", VA = "0x1826A6350", Slot = "21")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x26A6420", Offset = "0x26A4A20", VA = "0x1826A6420")]
		private void OnApplicationPause(bool paused)
		{
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x26A6440", Offset = "0x26A4A40", VA = "0x1826A6440", Slot = "16")]
		protected override void OnDisable()
		{
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x26A6460", Offset = "0x26A4A60", VA = "0x1826A6460")]
		private void OnDestroy()
		{
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x000043F8 File Offset: 0x000025F8
		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x26A6470", Offset = "0x26A4A70", VA = "0x1826A6470")]
		public bool UpdateVisibility(bool visibleByAlpha, bool visibleByPanel)
		{
			return default(bool);
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00004410 File Offset: 0x00002610
		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x26A64A0", Offset = "0x26A4AA0", VA = "0x1826A64A0")]
		public bool UpdateTransform(int frame)
		{
			return default(bool);
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00004428 File Offset: 0x00002628
		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x26A6CD0", Offset = "0x26A52D0", VA = "0x1826A6CD0")]
		public bool UpdateGeometry(int frame)
		{
			return default(bool);
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x26A71C0", Offset = "0x26A57C0", VA = "0x1826A71C0")]
		public void WriteToBuffers(BetterList<Vector3> v, BetterList<Vector2> u, BetterList<Color32> c, BetterList<Vector3> n, BetterList<Vector4> t)
		{
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x26A71F0", Offset = "0x26A57F0", VA = "0x1826A71F0", Slot = "33")]
		public virtual void MakePixelPerfect()
		{
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x00004440 File Offset: 0x00002640
		[Token(Token = "0x1700013F")]
		public virtual int minWidth
		{
			[Token(Token = "0x60005C0")]
			[Address(RVA = "0xE51970", Offset = "0xE4FF70", VA = "0x180E51970", Slot = "34")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x00004458 File Offset: 0x00002658
		[Token(Token = "0x17000140")]
		public virtual int minHeight
		{
			[Token(Token = "0x60005C1")]
			[Address(RVA = "0xE51970", Offset = "0xE4FF70", VA = "0x180E51970", Slot = "35")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x00004470 File Offset: 0x00002670
		// (set) Token: 0x060005C3 RID: 1475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000141")]
		public virtual Vector4 border
		{
			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x26A7440", Offset = "0x26A5A40", VA = "0x1826A7440", Slot = "36")]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "37")]
			set
			{
			}
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "38")]
		public virtual void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
		{
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x26A7490", Offset = "0x26A5A90", VA = "0x1826A7490")]
		public UIWidget()
		{
		}

		// Token: 0x040003B8 RID: 952
		[Token(Token = "0x40003B8")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[HideInInspector]
		protected Color mColor;

		// Token: 0x040003B9 RID: 953
		[Token(Token = "0x40003B9")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[HideInInspector]
		protected UIWidget.Pivot mPivot;

		// Token: 0x040003BA RID: 954
		[Token(Token = "0x40003BA")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		[HideInInspector]
		protected int mWidth;

		// Token: 0x040003BB RID: 955
		[Token(Token = "0x40003BB")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[HideInInspector]
		protected int mHeight;

		// Token: 0x040003BC RID: 956
		[Token(Token = "0x40003BC")]
		[FieldOffset(Offset = "0xB4")]
		[HideInInspector]
		[SerializeField]
		protected int mDepth;

		// Token: 0x040003BD RID: 957
		[Token(Token = "0x40003BD")]
		[FieldOffset(Offset = "0xB8")]
		public UIWidget.OnDimensionsChanged onChange;

		// Token: 0x040003BE RID: 958
		[Token(Token = "0x40003BE")]
		[FieldOffset(Offset = "0xC0")]
		public UIWidget.OnPostFillCallback onPostFill;

		// Token: 0x040003BF RID: 959
		[Token(Token = "0x40003BF")]
		[FieldOffset(Offset = "0xC8")]
		public UIDrawCall.OnRenderCallback mOnRender;

		// Token: 0x040003C0 RID: 960
		[Token(Token = "0x40003C0")]
		[FieldOffset(Offset = "0xD0")]
		public bool autoResizeBoxCollider;

		// Token: 0x040003C1 RID: 961
		[Token(Token = "0x40003C1")]
		[FieldOffset(Offset = "0xD1")]
		public bool hideIfOffScreen;

		// Token: 0x040003C2 RID: 962
		[Token(Token = "0x40003C2")]
		[FieldOffset(Offset = "0xD4")]
		public UIWidget.AspectRatioSource keepAspectRatio;

		// Token: 0x040003C3 RID: 963
		[Token(Token = "0x40003C3")]
		[FieldOffset(Offset = "0xD8")]
		public float aspectRatio;

		// Token: 0x040003C4 RID: 964
		[Token(Token = "0x40003C4")]
		[FieldOffset(Offset = "0xE0")]
		public UIWidget.HitCheck hitCheck;

		// Token: 0x040003C5 RID: 965
		[Token(Token = "0x40003C5")]
		[FieldOffset(Offset = "0xE8")]
		[NonSerialized]
		public UIPanel panel;

		// Token: 0x040003C6 RID: 966
		[Token(Token = "0x40003C6")]
		[FieldOffset(Offset = "0xF0")]
		[NonSerialized]
		public UIGeometry geometry;

		// Token: 0x040003C7 RID: 967
		[Token(Token = "0x40003C7")]
		[FieldOffset(Offset = "0xF8")]
		[NonSerialized]
		public bool fillGeometry;

		// Token: 0x040003C8 RID: 968
		[Token(Token = "0x40003C8")]
		[FieldOffset(Offset = "0xF9")]
		[NonSerialized]
		protected bool mPlayMode;

		// Token: 0x040003C9 RID: 969
		[Token(Token = "0x40003C9")]
		[FieldOffset(Offset = "0xFC")]
		[NonSerialized]
		protected Vector4 mDrawRegion;

		// Token: 0x040003CA RID: 970
		[Token(Token = "0x40003CA")]
		[FieldOffset(Offset = "0x10C")]
		[NonSerialized]
		private Matrix4x4 mLocalToPanel;

		// Token: 0x040003CB RID: 971
		[Token(Token = "0x40003CB")]
		[FieldOffset(Offset = "0x14C")]
		[NonSerialized]
		private bool mIsVisibleByAlpha;

		// Token: 0x040003CC RID: 972
		[Token(Token = "0x40003CC")]
		[FieldOffset(Offset = "0x14D")]
		[NonSerialized]
		private bool mIsVisibleByPanel;

		// Token: 0x040003CD RID: 973
		[Token(Token = "0x40003CD")]
		[FieldOffset(Offset = "0x14E")]
		[NonSerialized]
		private bool mIsInFront;

		// Token: 0x040003CE RID: 974
		[Token(Token = "0x40003CE")]
		[FieldOffset(Offset = "0x150")]
		[NonSerialized]
		private float mLastAlpha;

		// Token: 0x040003CF RID: 975
		[Token(Token = "0x40003CF")]
		[FieldOffset(Offset = "0x154")]
		[NonSerialized]
		private bool mMoved;

		// Token: 0x040003D0 RID: 976
		[Token(Token = "0x40003D0")]
		[FieldOffset(Offset = "0x158")]
		[NonSerialized]
		public UIDrawCall drawCall;

		// Token: 0x040003D1 RID: 977
		[Token(Token = "0x40003D1")]
		[FieldOffset(Offset = "0x160")]
		[NonSerialized]
		protected Vector3[] mCorners;

		// Token: 0x040003D2 RID: 978
		[Token(Token = "0x40003D2")]
		[FieldOffset(Offset = "0x168")]
		[NonSerialized]
		private int mAlphaFrameID;

		// Token: 0x040003D3 RID: 979
		[Token(Token = "0x40003D3")]
		[FieldOffset(Offset = "0x16C")]
		public bool SkipWidthUpdate;

		// Token: 0x040003D4 RID: 980
		[Token(Token = "0x40003D4")]
		[FieldOffset(Offset = "0x170")]
		private int mMatrixFrame;

		// Token: 0x040003D5 RID: 981
		[Token(Token = "0x40003D5")]
		[FieldOffset(Offset = "0x174")]
		private Vector3 mOldV0;

		// Token: 0x040003D6 RID: 982
		[Token(Token = "0x40003D6")]
		[FieldOffset(Offset = "0x180")]
		private Vector3 mOldV1;

		// Token: 0x02000091 RID: 145
		[Token(Token = "0x2000091")]
		public enum Pivot
		{
			// Token: 0x040003D8 RID: 984
			[Token(Token = "0x40003D8")]
			TopLeft,
			// Token: 0x040003D9 RID: 985
			[Token(Token = "0x40003D9")]
			Top,
			// Token: 0x040003DA RID: 986
			[Token(Token = "0x40003DA")]
			TopRight,
			// Token: 0x040003DB RID: 987
			[Token(Token = "0x40003DB")]
			Left,
			// Token: 0x040003DC RID: 988
			[Token(Token = "0x40003DC")]
			Center,
			// Token: 0x040003DD RID: 989
			[Token(Token = "0x40003DD")]
			Right,
			// Token: 0x040003DE RID: 990
			[Token(Token = "0x40003DE")]
			BottomLeft,
			// Token: 0x040003DF RID: 991
			[Token(Token = "0x40003DF")]
			Bottom,
			// Token: 0x040003E0 RID: 992
			[Token(Token = "0x40003E0")]
			BottomRight
		}

		// Token: 0x02000092 RID: 146
		// (Invoke) Token: 0x060005C7 RID: 1479
		[Token(Token = "0x2000092")]
		public delegate void OnDimensionsChanged();

		// Token: 0x02000093 RID: 147
		// (Invoke) Token: 0x060005CB RID: 1483
		[Token(Token = "0x2000093")]
		public delegate void OnPostFillCallback(UIWidget widget, int bufferOffset, BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols);

		// Token: 0x02000094 RID: 148
		[Token(Token = "0x2000094")]
		public enum AspectRatioSource
		{
			// Token: 0x040003E2 RID: 994
			[Token(Token = "0x40003E2")]
			Free,
			// Token: 0x040003E3 RID: 995
			[Token(Token = "0x40003E3")]
			BasedOnWidth,
			// Token: 0x040003E4 RID: 996
			[Token(Token = "0x40003E4")]
			BasedOnHeight
		}

		// Token: 0x02000095 RID: 149
		// (Invoke) Token: 0x060005CF RID: 1487
		[Token(Token = "0x2000095")]
		public delegate bool HitCheck(Vector3 worldPos);
	}
}
