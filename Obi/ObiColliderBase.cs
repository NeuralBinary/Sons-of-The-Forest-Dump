using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000153 RID: 339
	[Token(Token = "0x2000153")]
	public abstract class ObiColliderBase : MonoBehaviour
	{
		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x00002186 File Offset: 0x00000386
		// (set) Token: 0x060006A8 RID: 1704 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x170000E6")]
		public ObiCollisionMaterial CollisionMaterial
		{
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			set
			{
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060006AB RID: 1707 RVA: 0x0000437C File Offset: 0x0000257C
		// (set) Token: 0x060006AA RID: 1706 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x170000E7")]
		public int Phase
		{
			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x27CA170", Offset = "0x27C8770", VA = "0x1827CA170")]
			set
			{
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x00004394 File Offset: 0x00002594
		// (set) Token: 0x060006AC RID: 1708 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x170000E8")]
		public float Thickness
		{
			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x623BA0", Offset = "0x6221A0", VA = "0x180623BA0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x27CA180", Offset = "0x27C8780", VA = "0x1827CA180")]
			set
			{
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060006AE RID: 1710 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x170000E9")]
		public ObiShapeTracker Tracker
		{
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x170000EA")]
		public ObiColliderHandle Handle
		{
			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x27CA1C0", Offset = "0x27C87C0", VA = "0x1827CA1C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060006B0 RID: 1712 RVA: 0x000043AC File Offset: 0x000025AC
		[Token(Token = "0x170000EB")]
		public IntPtr OniCollider
		{
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x27CA200", Offset = "0x27C8800", VA = "0x1827CA200")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x170000EC")]
		public ObiRigidbodyBase Rigidbody
		{
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060006B2 RID: 1714
		[Token(Token = "0x60006B2")]
		protected abstract void CreateTracker();

		// Token: 0x060006B3 RID: 1715
		[Token(Token = "0x60006B3")]
		protected abstract Component GetUnityCollider(ref bool enabled);

		// Token: 0x060006B4 RID: 1716
		[Token(Token = "0x60006B4")]
		protected abstract void FindSourceCollider();

		// Token: 0x060006B5 RID: 1717 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x27CA240", Offset = "0x27C8840", VA = "0x1827CA240")]
		protected void CreateRigidbody()
		{
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x27CA710", Offset = "0x27C8D10", VA = "0x1827CA710")]
		private void OnTransformParentChanged()
		{
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x27CA720", Offset = "0x27C8D20", VA = "0x1827CA720")]
		protected void AddCollider()
		{
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x27CA910", Offset = "0x27C8F10", VA = "0x1827CA910")]
		protected void RemoveCollider()
		{
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x27CA9B0", Offset = "0x27C8FB0", VA = "0x1827CA9B0")]
		public void UpdateIfNeeded()
		{
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x120D1E0", Offset = "0x120B7E0", VA = "0x18120D1E0")]
		private void OnEnable()
		{
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x27CAAE0", Offset = "0x27C90E0", VA = "0x1827CAAE0")]
		private void OnDisable()
		{
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x26C07A0", Offset = "0x26BEDA0", VA = "0x1826C07A0")]
		protected ObiColliderBase()
		{
		}

		// Token: 0x040005AF RID: 1455
		[Token(Token = "0x40005AF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[SerializeProperty("CollisionMaterial")]
		private ObiCollisionMaterial material;

		// Token: 0x040005B0 RID: 1456
		[Token(Token = "0x40005B0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[SerializeProperty("Phase")]
		private int phase;

		// Token: 0x040005B1 RID: 1457
		[Token(Token = "0x40005B1")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[SerializeProperty("Thickness")]
		private float thickness;

		// Token: 0x040005B2 RID: 1458
		[Token(Token = "0x40005B2")]
		[FieldOffset(Offset = "0x30")]
		protected ObiColliderHandle shapeHandle;

		// Token: 0x040005B3 RID: 1459
		[Token(Token = "0x40005B3")]
		[FieldOffset(Offset = "0x38")]
		protected IntPtr oniCollider;

		// Token: 0x040005B4 RID: 1460
		[Token(Token = "0x40005B4")]
		[FieldOffset(Offset = "0x40")]
		protected ObiRigidbodyBase obiRigidbody;

		// Token: 0x040005B5 RID: 1461
		[Token(Token = "0x40005B5")]
		[FieldOffset(Offset = "0x48")]
		protected bool wasUnityColliderEnabled;

		// Token: 0x040005B6 RID: 1462
		[Token(Token = "0x40005B6")]
		[FieldOffset(Offset = "0x49")]
		protected bool dirty;

		// Token: 0x040005B7 RID: 1463
		[Token(Token = "0x40005B7")]
		[FieldOffset(Offset = "0x50")]
		protected ObiShapeTracker tracker;
	}
}
