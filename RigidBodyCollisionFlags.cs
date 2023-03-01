using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TheForest.Utils.Physics;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x0200015B RID: 347
[Token(Token = "0x200015B")]
[AddComponentMenu("Physics/Rigidbody Collision Flags")]
[RequireComponent(typeof(Collider))]
public class RigidBodyCollisionFlags : MonoBehaviour, IOnCollisionEnterProxy, IOnCollisionExitProxy, IOnCollisionStayProxy
{
	// Token: 0x17000145 RID: 325
	// (get) Token: 0x06000A31 RID: 2609 RVA: 0x00004890 File Offset: 0x00002A90
	[Token(Token = "0x17000145")]
	public CollisionFlags CollisionFlags
	{
		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x6B72D0", Offset = "0x6B62D0", VA = "0x1806B72D0")]
		get
		{
			return default(CollisionFlags);
		}
	}

	// Token: 0x17000146 RID: 326
	// (get) Token: 0x06000A32 RID: 2610 RVA: 0x000048A8 File Offset: 0x00002AA8
	[Token(Token = "0x17000146")]
	public bool AnyPointBelow
	{
		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x5F2450", Offset = "0x5F1450", VA = "0x1805F2450")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000147 RID: 327
	// (get) Token: 0x06000A33 RID: 2611 RVA: 0x000048C0 File Offset: 0x00002AC0
	[Token(Token = "0x17000147")]
	public float GroundAngleVal
	{
		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x2005410", Offset = "0x2004410", VA = "0x182005410")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x17000148 RID: 328
	// (get) Token: 0x06000A34 RID: 2612 RVA: 0x000048D8 File Offset: 0x00002AD8
	[Token(Token = "0x17000148")]
	public Vector3 GroundNormal
	{
		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x2885CA0", Offset = "0x2884CA0", VA = "0x182885CA0")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x06000A35 RID: 2613 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A35")]
	[Address(RVA = "0x2F4B380", Offset = "0x2F4A380", VA = "0x182F4B380")]
	private void Awake()
	{
	}

	// Token: 0x06000A36 RID: 2614 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A36")]
	[Address(RVA = "0x2F4B4D0", Offset = "0x2F4A4D0", VA = "0x182F4B4D0")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06000A37 RID: 2615 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A37")]
	[Address(RVA = "0x2F4C430", Offset = "0x2F4B430", VA = "0x182F4C430", Slot = "4")]
	public void OnCollisionEnterProxied(Collision other)
	{
	}

	// Token: 0x06000A38 RID: 2616 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A38")]
	[Address(RVA = "0x2F4C540", Offset = "0x2F4B540", VA = "0x182F4C540", Slot = "5")]
	public void OnCollisionExitProxied(Collision other)
	{
	}

	// Token: 0x06000A39 RID: 2617 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A39")]
	[Address(RVA = "0x2F4C5F0", Offset = "0x2F4B5F0", VA = "0x182F4C5F0", Slot = "6")]
	public void OnCollisionStayProxied(Collision collInfo)
	{
	}

	// Token: 0x06000A3A RID: 2618 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A3A")]
	[Address(RVA = "0x2F4B8D0", Offset = "0x2F4A8D0", VA = "0x182F4B8D0")]
	private void HandleBoxCollision(Vector3 bCenter, int count)
	{
	}

	// Token: 0x06000A3B RID: 2619 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A3B")]
	[Address(RVA = "0x2F4C160", Offset = "0x2F4B160", VA = "0x182F4C160")]
	private void HandleSphereCollision(Vector3 bCenter, int count)
	{
	}

	// Token: 0x06000A3C RID: 2620 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A3C")]
	[Address(RVA = "0x2F4BF20", Offset = "0x2F4AF20", VA = "0x182F4BF20")]
	private void HandleCapsuleCollision(Vector3 bCenter, int count)
	{
	}

	// Token: 0x06000A3D RID: 2621 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A3D")]
	[Address(RVA = "0x2F4BBA0", Offset = "0x2F4ABA0", VA = "0x182F4BBA0")]
	private void HandleCapsuleCollisionContact(ContactPoint contactPoint, Vector3 bottomRadPoint)
	{
	}

	// Token: 0x06000A3E RID: 2622 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A3E")]
	[Address(RVA = "0x2F4B530", Offset = "0x2F4A530", VA = "0x182F4B530")]
	private void GetCollType()
	{
	}

	// Token: 0x06000A3F RID: 2623 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A3F")]
	[Address(RVA = "0x2F4C940", Offset = "0x2F4B940", VA = "0x182F4C940")]
	public RigidBodyCollisionFlags()
	{
	}

	// Token: 0x040008AF RID: 2223
	[Token(Token = "0x40008AF")]
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("coll")]
	[SerializeField]
	private Collider _targetCollider;

	// Token: 0x040008B0 RID: 2224
	[Token(Token = "0x40008B0")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _heightOffset;

	// Token: 0x040008B1 RID: 2225
	[Token(Token = "0x40008B1")]
	[FieldOffset(Offset = "0x30")]
	private readonly List<GameObject> _collCheck;

	// Token: 0x040008B2 RID: 2226
	[Token(Token = "0x40008B2")]
	[FieldOffset(Offset = "0x38")]
	private readonly List<ContactPoint> _contacts;

	// Token: 0x040008B3 RID: 2227
	[Token(Token = "0x40008B3")]
	[FieldOffset(Offset = "0x40")]
	private bool _anyPointBelow;

	// Token: 0x040008B4 RID: 2228
	[Token(Token = "0x40008B4")]
	[FieldOffset(Offset = "0x44")]
	private CollisionFlags _collFlags;

	// Token: 0x040008B5 RID: 2229
	[Token(Token = "0x40008B5")]
	[FieldOffset(Offset = "0x48")]
	private int _collisionCount;

	// Token: 0x040008B6 RID: 2230
	[Token(Token = "0x40008B6")]
	[FieldOffset(Offset = "0x4C")]
	private RigidBodyCollisionFlags.ColliderType _collType;

	// Token: 0x040008B7 RID: 2231
	[Token(Token = "0x40008B7")]
	[FieldOffset(Offset = "0x50")]
	private float _groundAngleVal;

	// Token: 0x040008B8 RID: 2232
	[Token(Token = "0x40008B8")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	private float _groundAngleMaxConstruction;

	// Token: 0x040008B9 RID: 2233
	[Token(Token = "0x40008B9")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 _slopeNormal;

	// Token: 0x040008BA RID: 2234
	[Token(Token = "0x40008BA")]
	[FieldOffset(Offset = "0x68")]
	private BoxCollider _boxCollider;

	// Token: 0x040008BB RID: 2235
	[Token(Token = "0x40008BB")]
	[FieldOffset(Offset = "0x70")]
	private CapsuleCollider _capsuleCollider;

	// Token: 0x040008BC RID: 2236
	[Token(Token = "0x40008BC")]
	[FieldOffset(Offset = "0x78")]
	private bool _inContact;

	// Token: 0x040008BD RID: 2237
	[Token(Token = "0x40008BD")]
	[FieldOffset(Offset = "0x7C")]
	private int _lowStuckPointCount;

	// Token: 0x040008BE RID: 2238
	[Token(Token = "0x40008BE")]
	[FieldOffset(Offset = "0x80")]
	private SphereCollider _sphereCollider;

	// Token: 0x040008BF RID: 2239
	[Token(Token = "0x40008BF")]
	[FieldOffset(Offset = "0x88")]
	private int _stuckPointCount;

	// Token: 0x040008C0 RID: 2240
	[Token(Token = "0x40008C0")]
	[FieldOffset(Offset = "0x8C")]
	private bool _testBelow;

	// Token: 0x040008C1 RID: 2241
	[Token(Token = "0x40008C1")]
	[FieldOffset(Offset = "0x90")]
	private Transform _transform;

	// Token: 0x040008C2 RID: 2242
	[Token(Token = "0x40008C2")]
	[FieldOffset(Offset = "0x98")]
	private LayerMask _smoothedLayerMask;

	// Token: 0x0200015C RID: 348
	[Token(Token = "0x200015C")]
	private enum ColliderType
	{
		// Token: 0x040008C4 RID: 2244
		[Token(Token = "0x40008C4")]
		Unknown,
		// Token: 0x040008C5 RID: 2245
		[Token(Token = "0x40008C5")]
		Capsule,
		// Token: 0x040008C6 RID: 2246
		[Token(Token = "0x40008C6")]
		Sphere,
		// Token: 0x040008C7 RID: 2247
		[Token(Token = "0x40008C7")]
		Box
	}
}
