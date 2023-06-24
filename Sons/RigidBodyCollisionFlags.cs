using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TheForest.Utils.Physics;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x0200015A RID: 346
[Token(Token = "0x200015A")]
[RequireComponent(typeof(Collider))]
[AddComponentMenu("Physics/Rigidbody Collision Flags")]
public class RigidBodyCollisionFlags : MonoBehaviour, IOnCollisionEnterProxy, IOnCollisionExitProxy, IOnCollisionStayProxy
{
	// Token: 0x1700014E RID: 334
	// (get) Token: 0x06000A81 RID: 2689 RVA: 0x00004AA0 File Offset: 0x00002CA0
	[Token(Token = "0x1700014E")]
	public CollisionFlags CollisionFlags
	{
		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x76BE00", Offset = "0x76A400", VA = "0x18076BE00")]
		get
		{
			return CollisionFlags.None;
		}
	}

	// Token: 0x1700014F RID: 335
	// (get) Token: 0x06000A82 RID: 2690 RVA: 0x00004AB8 File Offset: 0x00002CB8
	[Token(Token = "0x1700014F")]
	public bool AnyPointBelow
	{
		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x674880", Offset = "0x672E80", VA = "0x180674880")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000150 RID: 336
	// (get) Token: 0x06000A83 RID: 2691 RVA: 0x00004AD0 File Offset: 0x00002CD0
	[Token(Token = "0x17000150")]
	public float GroundAngleVal
	{
		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x23A8BF0", Offset = "0x23A71F0", VA = "0x1823A8BF0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000151 RID: 337
	// (get) Token: 0x06000A84 RID: 2692 RVA: 0x00004AE8 File Offset: 0x00002CE8
	[Token(Token = "0x17000151")]
	public Vector3 GroundNormal
	{
		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x2D7D380", Offset = "0x2D7B980", VA = "0x182D7D380")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x06000A85 RID: 2693 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A85")]
	[Address(RVA = "0x36B60D0", Offset = "0x36B46D0", VA = "0x1836B60D0")]
	private void Awake()
	{
	}

	// Token: 0x06000A86 RID: 2694 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A86")]
	[Address(RVA = "0x36B6310", Offset = "0x36B4910", VA = "0x1836B6310")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06000A87 RID: 2695 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A87")]
	[Address(RVA = "0x36B6370", Offset = "0x36B4970", VA = "0x1836B6370", Slot = "4")]
	public void OnCollisionEnterProxied(Collision other)
	{
	}

	// Token: 0x06000A88 RID: 2696 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A88")]
	[Address(RVA = "0x36B6410", Offset = "0x36B4A10", VA = "0x1836B6410", Slot = "5")]
	public void OnCollisionExitProxied(Collision other)
	{
	}

	// Token: 0x06000A89 RID: 2697 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A89")]
	[Address(RVA = "0x36B64C0", Offset = "0x36B4AC0", VA = "0x1836B64C0", Slot = "6")]
	public void OnCollisionStayProxied(Collision collInfo)
	{
	}

	// Token: 0x06000A8A RID: 2698 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A8A")]
	[Address(RVA = "0x36B6720", Offset = "0x36B4D20", VA = "0x1836B6720")]
	private void HandleBoxCollision(Vector3 bCenter, int count)
	{
	}

	// Token: 0x06000A8B RID: 2699 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A8B")]
	[Address(RVA = "0x36B6970", Offset = "0x36B4F70", VA = "0x1836B6970")]
	private void HandleSphereCollision(Vector3 bCenter, int count)
	{
	}

	// Token: 0x06000A8C RID: 2700 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A8C")]
	[Address(RVA = "0x36B6BC0", Offset = "0x36B51C0", VA = "0x1836B6BC0")]
	private void HandleCapsuleCollision(Vector3 bCenter, int count)
	{
	}

	// Token: 0x06000A8D RID: 2701 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A8D")]
	[Address(RVA = "0x36B6ED0", Offset = "0x36B54D0", VA = "0x1836B6ED0")]
	private void HandleCapsuleCollisionContact(ContactPoint contactPoint, Vector3 bottomRadPoint)
	{
	}

	// Token: 0x06000A8E RID: 2702 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A8E")]
	[Address(RVA = "0x36B72A0", Offset = "0x36B58A0", VA = "0x1836B72A0")]
	private void GetCollType()
	{
	}

	// Token: 0x06000A8F RID: 2703 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A8F")]
	[Address(RVA = "0x36B77A0", Offset = "0x36B5DA0", VA = "0x1836B77A0")]
	public RigidBodyCollisionFlags()
	{
	}

	// Token: 0x040008D0 RID: 2256
	[Token(Token = "0x40008D0")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[FormerlySerializedAs("coll")]
	private Collider _targetCollider;

	// Token: 0x040008D1 RID: 2257
	[Token(Token = "0x40008D1")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _heightOffset;

	// Token: 0x040008D2 RID: 2258
	[Token(Token = "0x40008D2")]
	[FieldOffset(Offset = "0x30")]
	private readonly List<GameObject> _collCheck;

	// Token: 0x040008D3 RID: 2259
	[Token(Token = "0x40008D3")]
	[FieldOffset(Offset = "0x38")]
	private readonly List<ContactPoint> _contacts;

	// Token: 0x040008D4 RID: 2260
	[Token(Token = "0x40008D4")]
	[FieldOffset(Offset = "0x40")]
	private bool _anyPointBelow;

	// Token: 0x040008D5 RID: 2261
	[Token(Token = "0x40008D5")]
	[FieldOffset(Offset = "0x44")]
	private CollisionFlags _collFlags;

	// Token: 0x040008D6 RID: 2262
	[Token(Token = "0x40008D6")]
	[FieldOffset(Offset = "0x48")]
	private int _collisionCount;

	// Token: 0x040008D7 RID: 2263
	[Token(Token = "0x40008D7")]
	[FieldOffset(Offset = "0x4C")]
	private RigidBodyCollisionFlags.ColliderType _collType;

	// Token: 0x040008D8 RID: 2264
	[Token(Token = "0x40008D8")]
	[FieldOffset(Offset = "0x50")]
	private float _groundAngleVal;

	// Token: 0x040008D9 RID: 2265
	[Token(Token = "0x40008D9")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	private float _groundAngleMaxConstruction;

	// Token: 0x040008DA RID: 2266
	[Token(Token = "0x40008DA")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 _slopeNormal;

	// Token: 0x040008DB RID: 2267
	[Token(Token = "0x40008DB")]
	[FieldOffset(Offset = "0x68")]
	private BoxCollider _boxCollider;

	// Token: 0x040008DC RID: 2268
	[Token(Token = "0x40008DC")]
	[FieldOffset(Offset = "0x70")]
	private CapsuleCollider _capsuleCollider;

	// Token: 0x040008DD RID: 2269
	[Token(Token = "0x40008DD")]
	[FieldOffset(Offset = "0x78")]
	private bool _inContact;

	// Token: 0x040008DE RID: 2270
	[Token(Token = "0x40008DE")]
	[FieldOffset(Offset = "0x7C")]
	private int _lowStuckPointCount;

	// Token: 0x040008DF RID: 2271
	[Token(Token = "0x40008DF")]
	[FieldOffset(Offset = "0x80")]
	private SphereCollider _sphereCollider;

	// Token: 0x040008E0 RID: 2272
	[Token(Token = "0x40008E0")]
	[FieldOffset(Offset = "0x88")]
	private int _stuckPointCount;

	// Token: 0x040008E1 RID: 2273
	[Token(Token = "0x40008E1")]
	[FieldOffset(Offset = "0x8C")]
	private bool _testBelow;

	// Token: 0x040008E2 RID: 2274
	[Token(Token = "0x40008E2")]
	[FieldOffset(Offset = "0x90")]
	private Transform _transform;

	// Token: 0x040008E3 RID: 2275
	[Token(Token = "0x40008E3")]
	[FieldOffset(Offset = "0x98")]
	private LayerMask _smoothedLayerMask;

	// Token: 0x0200015B RID: 347
	[Token(Token = "0x200015B")]
	private enum ColliderType
	{
		// Token: 0x040008E5 RID: 2277
		[Token(Token = "0x40008E5")]
		Unknown,
		// Token: 0x040008E6 RID: 2278
		[Token(Token = "0x40008E6")]
		Capsule,
		// Token: 0x040008E7 RID: 2279
		[Token(Token = "0x40008E7")]
		Sphere,
		// Token: 0x040008E8 RID: 2280
		[Token(Token = "0x40008E8")]
		Box
	}
}
