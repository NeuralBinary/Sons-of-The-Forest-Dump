using System;
using Il2CppDummyDll;
using NGUI.UI;
using UnityEngine;

namespace NGUI.Internal
{
	// Token: 0x0200008C RID: 140
	[Token(Token = "0x200008C")]
	public abstract class UIRect : MonoBehaviour
	{
		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600054A RID: 1354 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000119")]
		public GameObject cachedGameObject
		{
			[Token(Token = "0x600054A")]
			[Address(RVA = "0x269B840", Offset = "0x2699E40", VA = "0x18269B840")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700011A")]
		public Transform cachedTransform
		{
			[Token(Token = "0x600054B")]
			[Address(RVA = "0x269B9A0", Offset = "0x2699FA0", VA = "0x18269B9A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700011B")]
		public Camera anchorCamera
		{
			[Token(Token = "0x600054C")]
			[Address(RVA = "0x269BB00", Offset = "0x269A100", VA = "0x18269BB00")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x00004110 File Offset: 0x00002310
		[Token(Token = "0x1700011C")]
		public bool isFullyAnchored
		{
			[Token(Token = "0x600054D")]
			[Address(RVA = "0x269BB30", Offset = "0x269A130", VA = "0x18269BB30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x00004128 File Offset: 0x00002328
		[Token(Token = "0x1700011D")]
		public virtual bool isAnchoredHorizontally
		{
			[Token(Token = "0x600054E")]
			[Address(RVA = "0x269BD70", Offset = "0x269A370", VA = "0x18269BD70", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x00004140 File Offset: 0x00002340
		[Token(Token = "0x1700011E")]
		public virtual bool isAnchoredVertically
		{
			[Token(Token = "0x600054F")]
			[Address(RVA = "0x269BEF0", Offset = "0x269A4F0", VA = "0x18269BEF0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x00004158 File Offset: 0x00002358
		[Token(Token = "0x1700011F")]
		public virtual bool canBeAnchored
		{
			[Token(Token = "0x6000550")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000120")]
		public UIRect parent
		{
			[Token(Token = "0x6000551")]
			[Address(RVA = "0x269C070", Offset = "0x269A670", VA = "0x18269C070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000121")]
		public UIRoot root
		{
			[Token(Token = "0x6000552")]
			[Address(RVA = "0x269C1A0", Offset = "0x269A7A0", VA = "0x18269C1A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x00004170 File Offset: 0x00002370
		[Token(Token = "0x17000122")]
		public bool isAnchored
		{
			[Token(Token = "0x6000553")]
			[Address(RVA = "0x269C340", Offset = "0x269A940", VA = "0x18269C340")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000554 RID: 1364
		// (set) Token: 0x06000555 RID: 1365
		[Token(Token = "0x17000123")]
		public abstract float alpha { [Token(Token = "0x6000554")] get; [Token(Token = "0x6000555")] set; }

		// Token: 0x06000556 RID: 1366
		[Token(Token = "0x6000556")]
		public abstract float CalculateFinalAlpha(int frameID);

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000557 RID: 1367
		[Token(Token = "0x17000124")]
		public abstract Vector3[] localCorners { [Token(Token = "0x6000557")] get; }

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000558 RID: 1368
		[Token(Token = "0x17000125")]
		public abstract Vector3[] worldCorners { [Token(Token = "0x6000558")] get; }

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x00004188 File Offset: 0x00002388
		[Token(Token = "0x17000126")]
		protected float cameraRayDistance
		{
			[Token(Token = "0x6000559")]
			[Address(RVA = "0x269C590", Offset = "0x269AB90", VA = "0x18269C590")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055A")]
		[Address(RVA = "0x269CB40", Offset = "0x269B140", VA = "0x18269CB40", Slot = "12")]
		public virtual void Invalidate(bool includeChildren)
		{
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600055B")]
		[Address(RVA = "0x269CBD0", Offset = "0x269B1D0", VA = "0x18269CBD0", Slot = "13")]
		public virtual Vector3[] GetSides(Transform relativeTo)
		{
			return null;
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x000041A0 File Offset: 0x000023A0
		[Token(Token = "0x600055C")]
		[Address(RVA = "0x269CF80", Offset = "0x269B580", VA = "0x18269CF80")]
		protected Vector3 GetLocalPos(UIRect.AnchorPoint ac, Transform trans)
		{
			return default(Vector3);
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055D")]
		[Address(RVA = "0x269D4D0", Offset = "0x269BAD0", VA = "0x18269D4D0", Slot = "14")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055E")]
		[Address(RVA = "0x269D520", Offset = "0x269BB20", VA = "0x18269D520", Slot = "15")]
		protected virtual void OnInit()
		{
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055F")]
		[Address(RVA = "0x269D630", Offset = "0x269BC30", VA = "0x18269D630", Slot = "16")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000560")]
		[Address(RVA = "0x269D7E0", Offset = "0x269BDE0", VA = "0x18269D7E0")]
		protected void Start()
		{
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000561")]
		[Address(RVA = "0x269D820", Offset = "0x269BE20", VA = "0x18269D820")]
		public void Update()
		{
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000562")]
		[Address(RVA = "0x269D8B0", Offset = "0x269BEB0", VA = "0x18269D8B0")]
		protected void UpdateAnchorsInternal(int frame)
		{
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000563")]
		[Address(RVA = "0x269DE90", Offset = "0x269C490", VA = "0x18269DE90")]
		public void UpdateAnchors()
		{
		}

		// Token: 0x06000564 RID: 1380
		[Token(Token = "0x6000564")]
		protected abstract void OnAnchor();

		// Token: 0x06000565 RID: 1381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x269DF10", Offset = "0x269C510", VA = "0x18269DF10")]
		public void SetAnchor(Transform t)
		{
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x269E0C0", Offset = "0x269C6C0", VA = "0x18269E0C0")]
		public void SetAnchor(GameObject go)
		{
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000567")]
		[Address(RVA = "0x269E370", Offset = "0x269C970", VA = "0x18269E370")]
		public void SetAnchor(GameObject go, int left, int bottom, int right, int top)
		{
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000568")]
		[Address(RVA = "0x269E6B0", Offset = "0x269CCB0", VA = "0x18269E6B0")]
		public void ResetAnchors()
		{
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000569")]
		[Address(RVA = "0x269EC70", Offset = "0x269D270", VA = "0x18269EC70")]
		public void ResetAndUpdateAnchors()
		{
		}

		// Token: 0x0600056A RID: 1386
		[Token(Token = "0x600056A")]
		public abstract void SetRect(float x, float y, float width, float height);

		// Token: 0x0600056B RID: 1387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600056B")]
		[Address(RVA = "0x269EC90", Offset = "0x269D290", VA = "0x18269EC90")]
		private void FindCameraFor(UIRect.AnchorPoint ap)
		{
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x269EF80", Offset = "0x269D580", VA = "0x18269EF80", Slot = "19")]
		public virtual void ParentHasChanged()
		{
		}

		// Token: 0x0600056D RID: 1389
		[Token(Token = "0x600056D")]
		protected abstract void OnStart();

		// Token: 0x0600056E RID: 1390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600056E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "21")]
		protected virtual void OnUpdate()
		{
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600056F")]
		[Address(RVA = "0x269F320", Offset = "0x269D920", VA = "0x18269F320")]
		protected UIRect()
		{
		}

		// Token: 0x04000395 RID: 917
		[Token(Token = "0x4000395")]
		[FieldOffset(Offset = "0x20")]
		public UIRect.AnchorPoint leftAnchor;

		// Token: 0x04000396 RID: 918
		[Token(Token = "0x4000396")]
		[FieldOffset(Offset = "0x28")]
		public UIRect.AnchorPoint rightAnchor;

		// Token: 0x04000397 RID: 919
		[Token(Token = "0x4000397")]
		[FieldOffset(Offset = "0x30")]
		public UIRect.AnchorPoint bottomAnchor;

		// Token: 0x04000398 RID: 920
		[Token(Token = "0x4000398")]
		[FieldOffset(Offset = "0x38")]
		public UIRect.AnchorPoint topAnchor;

		// Token: 0x04000399 RID: 921
		[Token(Token = "0x4000399")]
		[FieldOffset(Offset = "0x40")]
		public UIRect.AnchorUpdate updateAnchors;

		// Token: 0x0400039A RID: 922
		[Token(Token = "0x400039A")]
		[FieldOffset(Offset = "0x48")]
		protected GameObject mGo;

		// Token: 0x0400039B RID: 923
		[Token(Token = "0x400039B")]
		[FieldOffset(Offset = "0x50")]
		protected Transform mTrans;

		// Token: 0x0400039C RID: 924
		[Token(Token = "0x400039C")]
		[FieldOffset(Offset = "0x58")]
		protected BetterList<UIRect> mChildren;

		// Token: 0x0400039D RID: 925
		[Token(Token = "0x400039D")]
		[FieldOffset(Offset = "0x60")]
		protected bool mChanged;

		// Token: 0x0400039E RID: 926
		[Token(Token = "0x400039E")]
		[FieldOffset(Offset = "0x61")]
		protected bool mStarted;

		// Token: 0x0400039F RID: 927
		[Token(Token = "0x400039F")]
		[FieldOffset(Offset = "0x62")]
		protected bool mParentFound;

		// Token: 0x040003A0 RID: 928
		[Token(Token = "0x40003A0")]
		[FieldOffset(Offset = "0x63")]
		[NonSerialized]
		private bool mUpdateAnchors;

		// Token: 0x040003A1 RID: 929
		[Token(Token = "0x40003A1")]
		[FieldOffset(Offset = "0x64")]
		[NonSerialized]
		private int mUpdateFrame;

		// Token: 0x040003A2 RID: 930
		[Token(Token = "0x40003A2")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		private bool mAnchorsCached;

		// Token: 0x040003A3 RID: 931
		[Token(Token = "0x40003A3")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		private UIRoot mRoot;

		// Token: 0x040003A4 RID: 932
		[Token(Token = "0x40003A4")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		private UIRect mParent;

		// Token: 0x040003A5 RID: 933
		[Token(Token = "0x40003A5")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		private bool mRootSet;

		// Token: 0x040003A6 RID: 934
		[Token(Token = "0x40003A6")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		protected Camera mCam;

		// Token: 0x040003A7 RID: 935
		[Token(Token = "0x40003A7")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		public float finalAlpha;

		// Token: 0x040003A8 RID: 936
		[Token(Token = "0x40003A8")]
		[FieldOffset(Offset = "0x0")]
		protected static Vector3[] mSides;

		// Token: 0x0200008D RID: 141
		[Token(Token = "0x200008D")]
		[Serializable]
		public class AnchorPoint
		{
			// Token: 0x06000571 RID: 1393 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000571")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public AnchorPoint()
			{
			}

			// Token: 0x06000572 RID: 1394 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000572")]
			[Address(RVA = "0xA308C0", Offset = "0xA2EEC0", VA = "0x180A308C0")]
			public AnchorPoint(float relative)
			{
			}

			// Token: 0x06000573 RID: 1395 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000573")]
			[Address(RVA = "0x269F660", Offset = "0x269DC60", VA = "0x18269F660")]
			public void Set(float relative, float absolute)
			{
			}

			// Token: 0x06000574 RID: 1396 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000574")]
			[Address(RVA = "0x269F690", Offset = "0x269DC90", VA = "0x18269F690")]
			public void Set(Transform target, float relative, float absolute)
			{
			}

			// Token: 0x06000575 RID: 1397 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000575")]
			[Address(RVA = "0x269F710", Offset = "0x269DD10", VA = "0x18269F710")]
			public void SetToNearest(float abs0, float abs1, float abs2)
			{
			}

			// Token: 0x06000576 RID: 1398 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000576")]
			[Address(RVA = "0x269F7C0", Offset = "0x269DDC0", VA = "0x18269F7C0")]
			public void SetToNearest(float rel0, float rel1, float rel2, float abs0, float abs1, float abs2)
			{
			}

			// Token: 0x06000577 RID: 1399 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000577")]
			[Address(RVA = "0x269F890", Offset = "0x269DE90", VA = "0x18269F890")]
			public void SetHorizontal(Transform parent, float localPos)
			{
			}

			// Token: 0x06000578 RID: 1400 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000578")]
			[Address(RVA = "0x269FBA0", Offset = "0x269E1A0", VA = "0x18269FBA0")]
			public void SetVertical(Transform parent, float localPos)
			{
			}

			// Token: 0x06000579 RID: 1401 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000579")]
			[Address(RVA = "0x269FEA0", Offset = "0x269E4A0", VA = "0x18269FEA0")]
			public Vector3[] GetSides(Transform relativeTo)
			{
				return null;
			}

			// Token: 0x040003A9 RID: 937
			[Token(Token = "0x40003A9")]
			[FieldOffset(Offset = "0x10")]
			public Transform target;

			// Token: 0x040003AA RID: 938
			[Token(Token = "0x40003AA")]
			[FieldOffset(Offset = "0x18")]
			public float relative;

			// Token: 0x040003AB RID: 939
			[Token(Token = "0x40003AB")]
			[FieldOffset(Offset = "0x1C")]
			public int absolute;

			// Token: 0x040003AC RID: 940
			[Token(Token = "0x40003AC")]
			[FieldOffset(Offset = "0x20")]
			[NonSerialized]
			public UIRect rect;

			// Token: 0x040003AD RID: 941
			[Token(Token = "0x40003AD")]
			[FieldOffset(Offset = "0x28")]
			[NonSerialized]
			public Camera targetCam;
		}

		// Token: 0x0200008E RID: 142
		[Token(Token = "0x200008E")]
		public enum AnchorUpdate
		{
			// Token: 0x040003AF RID: 943
			[Token(Token = "0x40003AF")]
			OnEnable,
			// Token: 0x040003B0 RID: 944
			[Token(Token = "0x40003B0")]
			OnUpdate,
			// Token: 0x040003B1 RID: 945
			[Token(Token = "0x40003B1")]
			OnStart
		}
	}
}
