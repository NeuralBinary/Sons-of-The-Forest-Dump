using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.UI
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	[ExecuteInEditMode]
	[AddComponentMenu("NGUI/UI/Root")]
	public class UIRoot : MonoBehaviour
	{
		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600020A RID: 522 RVA: 0x00002E20 File Offset: 0x00001020
		[Token(Token = "0x1700008C")]
		public UIRoot.Constraint constraint
		{
			[Token(Token = "0x600020A")]
			[Address(RVA = "0x264AB80", Offset = "0x2649180", VA = "0x18264AB80")]
			get
			{
				return UIRoot.Constraint.Fit;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600020B RID: 523 RVA: 0x00002E38 File Offset: 0x00001038
		[Token(Token = "0x1700008D")]
		public UIRoot.Scaling activeScaling
		{
			[Token(Token = "0x600020B")]
			[Address(RVA = "0x264ABB0", Offset = "0x26491B0", VA = "0x18264ABB0")]
			get
			{
				return UIRoot.Scaling.Flexible;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600020C RID: 524 RVA: 0x00002E50 File Offset: 0x00001050
		[Token(Token = "0x1700008E")]
		public int activeHeight
		{
			[Token(Token = "0x600020C")]
			[Address(RVA = "0x264ABC0", Offset = "0x26491C0", VA = "0x18264ABC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600020D RID: 525 RVA: 0x00002E68 File Offset: 0x00001068
		[Token(Token = "0x1700008F")]
		public float pixelSizeAdjustment
		{
			[Token(Token = "0x600020D")]
			[Address(RVA = "0x264AE40", Offset = "0x2649440", VA = "0x18264AE40")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002E80 File Offset: 0x00001080
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x264AF40", Offset = "0x2649540", VA = "0x18264AF40")]
		public static float GetPixelSizeAdjustment(GameObject go)
		{
			return 0f;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002E98 File Offset: 0x00001098
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x264B050", Offset = "0x2649650", VA = "0x18264B050")]
		public float GetPixelSizeAdjustment(int height)
		{
			return 0f;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x264B0B0", Offset = "0x26496B0", VA = "0x18264B0B0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x264B160", Offset = "0x2649760", VA = "0x18264B160", Slot = "5")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x264B220", Offset = "0x2649820", VA = "0x18264B220", Slot = "6")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x264B2A0", Offset = "0x26498A0", VA = "0x18264B2A0", Slot = "7")]
		protected virtual void Start()
		{
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x264B520", Offset = "0x2649B20", VA = "0x18264B520")]
		private void Update()
		{
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x264B530", Offset = "0x2649B30", VA = "0x18264B530")]
		public void UpdateScale(bool updateAnchors = true)
		{
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x264B790", Offset = "0x2649D90", VA = "0x18264B790")]
		public static void Broadcast(string funcName)
		{
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x264B960", Offset = "0x2649F60", VA = "0x18264B960")]
		public static void Broadcast(string funcName, object param)
		{
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x264BB90", Offset = "0x264A190", VA = "0x18264BB90")]
		public UIRoot()
		{
		}

		// Token: 0x04000192 RID: 402
		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x0")]
		public static List<UIRoot> list;

		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x20")]
		public UIRoot.Scaling scalingStyle;

		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x24")]
		public int manualWidth;

		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x28")]
		public int manualHeight;

		// Token: 0x04000196 RID: 406
		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x2C")]
		public int minimumHeight;

		// Token: 0x04000197 RID: 407
		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x30")]
		public int maximumHeight;

		// Token: 0x04000198 RID: 408
		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x34")]
		public bool fitWidth;

		// Token: 0x04000199 RID: 409
		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x35")]
		public bool fitHeight;

		// Token: 0x0400019A RID: 410
		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x36")]
		public bool adjustByDPI;

		// Token: 0x0400019B RID: 411
		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x37")]
		public bool shrinkPortraitUI;

		// Token: 0x0400019C RID: 412
		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x38")]
		private Transform mTrans;

		// Token: 0x02000039 RID: 57
		[Token(Token = "0x2000039")]
		public enum Scaling
		{
			// Token: 0x0400019E RID: 414
			[Token(Token = "0x400019E")]
			Flexible,
			// Token: 0x0400019F RID: 415
			[Token(Token = "0x400019F")]
			Constrained,
			// Token: 0x040001A0 RID: 416
			[Token(Token = "0x40001A0")]
			ConstrainedOnMobiles
		}

		// Token: 0x0200003A RID: 58
		[Token(Token = "0x200003A")]
		public enum Constraint
		{
			// Token: 0x040001A2 RID: 418
			[Token(Token = "0x40001A2")]
			Fit,
			// Token: 0x040001A3 RID: 419
			[Token(Token = "0x40001A3")]
			Fill,
			// Token: 0x040001A4 RID: 420
			[Token(Token = "0x40001A4")]
			FitWidth,
			// Token: 0x040001A5 RID: 421
			[Token(Token = "0x40001A5")]
			FitHeight
		}
	}
}
