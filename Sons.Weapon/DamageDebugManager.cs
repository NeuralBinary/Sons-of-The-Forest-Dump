using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Endnight.Types;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000003 RID: 3
[Token(Token = "0x2000003")]
[AddComponentMenu("Sons/Weapon/Damage Debug Manager")]
public class DamageDebugManager : SingletonBehaviour<DamageDebugManager>
{
	// Token: 0x0600000C RID: 12 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x318ED40", Offset = "0x318D340", VA = "0x18318ED40")]
	public static void SetPlayerMeleeShowTime(float value)
	{
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x318EDE0", Offset = "0x318D3E0", VA = "0x18318EDE0")]
	public static void SetVailMeleeShowTime(float value)
	{
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x318EE80", Offset = "0x318D480", VA = "0x18318EE80")]
	public static void SetPlayerMeleeDebug(bool value)
	{
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x0600000F RID: 15 RVA: 0x00002080 File Offset: 0x00000280
	// (set) Token: 0x06000010 RID: 16 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000003")]
	public static bool PlayerMeleeDebug
	{
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x318EEC0", Offset = "0x318D4C0", VA = "0x18318EEC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x318EF00", Offset = "0x318D500", VA = "0x18318EF00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000011")]
	[Address(RVA = "0x318EF40", Offset = "0x318D540", VA = "0x18318EF40")]
	public static void SetDamageDebug(bool value)
	{
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000012 RID: 18 RVA: 0x00002098 File Offset: 0x00000298
	// (set) Token: 0x06000013 RID: 19 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000004")]
	public static bool DamageDebug
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x318EF80", Offset = "0x318D580", VA = "0x18318EF80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x318EFC0", Offset = "0x318D5C0", VA = "0x18318EFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x318F000", Offset = "0x318D600", VA = "0x18318F000")]
	public static void SetEnemyGodMode(bool value)
	{
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000015 RID: 21 RVA: 0x000020B0 File Offset: 0x000002B0
	// (set) Token: 0x06000016 RID: 22 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000005")]
	public static bool EnemyGodMode
	{
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x318F040", Offset = "0x318D640", VA = "0x18318F040")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x318F080", Offset = "0x318D680", VA = "0x18318F080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000017")]
	[Address(RVA = "0x318F0C0", Offset = "0x318D6C0", VA = "0x18318F0C0")]
	public static void SetEnemyKnockdownsOff(bool value)
	{
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000018 RID: 24 RVA: 0x000020C8 File Offset: 0x000002C8
	// (set) Token: 0x06000019 RID: 25 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000006")]
	public static bool EnemyKnockdownsOff
	{
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x318F100", Offset = "0x318D700", VA = "0x18318F100")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x318F140", Offset = "0x318D740", VA = "0x18318F140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x318F180", Offset = "0x318D780", VA = "0x18318F180")]
	public static void SetLogPlayerHit(bool value)
	{
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x0600001B RID: 27 RVA: 0x000020E0 File Offset: 0x000002E0
	// (set) Token: 0x0600001C RID: 28 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000007")]
	public static bool LogPlayerHit
	{
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x318F1C0", Offset = "0x318D7C0", VA = "0x18318F1C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x318F200", Offset = "0x318D800", VA = "0x18318F200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x318F240", Offset = "0x318D840", VA = "0x18318F240")]
	private void FixedUpdate()
	{
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x318F4C0", Offset = "0x318DAC0", VA = "0x18318F4C0")]
	private void Update()
	{
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x318F700", Offset = "0x318DD00", VA = "0x18318F700")]
	private void UpdateLineRenderer()
	{
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000020")]
	[Address(RVA = "0x318FAA0", Offset = "0x318E0A0", VA = "0x18318FAA0")]
	public static void AddCollider(Transform t, Collider c, bool player)
	{
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x31905E0", Offset = "0x318EBE0", VA = "0x1831905E0")]
	private void AddColliderInternal(Transform t, CapsuleCollider c, bool player)
	{
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x3190BD0", Offset = "0x318F1D0", VA = "0x183190BD0")]
	private void AddColliderInternal(Transform t, BoxCollider c, bool player)
	{
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000023")]
	[Address(RVA = "0x3190E60", Offset = "0x318F460", VA = "0x183190E60")]
	private void AddColliderInternal(Transform t, SphereCollider c, bool player)
	{
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000024")]
	[Address(RVA = "0x31910E0", Offset = "0x318F6E0", VA = "0x1831910E0")]
	private void NewColliderObject(GameObject prefab, Vector3 position, Quaternion rotation, Vector3 scale, bool player)
	{
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x31914E0", Offset = "0x318FAE0", VA = "0x1831914E0")]
	public static void ShowLine(Vector3 startPos, Vector3 endPos)
	{
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000026")]
	[Address(RVA = "0x3191650", Offset = "0x318FC50", VA = "0x183191650")]
	public static void AddDamageEvent(Vector3 pos, float damage)
	{
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000027")]
	[Address(RVA = "0x31917C0", Offset = "0x318FDC0", VA = "0x1831917C0")]
	public void AddDamageEventInternal(Vector3 pos, float damage)
	{
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000028")]
	[Address(RVA = "0x31918E0", Offset = "0x318FEE0", VA = "0x1831918E0")]
	public static void OnOverlayGUI()
	{
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000029")]
	[Address(RVA = "0x3191940", Offset = "0x318FF40", VA = "0x183191940")]
	public void OnOverlayGUIInternal()
	{
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600002A")]
	[Address(RVA = "0x3192190", Offset = "0x3190790", VA = "0x183192190")]
	public DamageDebugManager()
	{
	}

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _displayPlayerColliderTime;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float _displayVailColliderTime;

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject _capsuleObject;

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject _boxObject;

	// Token: 0x04000008 RID: 8
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject _sphereObject;

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float _displayDamageTime;

	// Token: 0x0400000A RID: 10
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float _displayLineTime;

	// Token: 0x0400000B RID: 11
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private LineRenderer _lineRendererPrefab;

	// Token: 0x0400000C RID: 12
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x58")]
	private GUIStyle _damageTextStyle;

	// Token: 0x04000012 RID: 18
	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x60")]
	private readonly List<Vector3> _linePositions;

	// Token: 0x04000013 RID: 19
	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x68")]
	private readonly List<DamageDebugManager.ShapeDebugInfo> _shapeList;

	// Token: 0x04000014 RID: 20
	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x70")]
	private readonly List<DamageDebugManager.DamageEvent> _damageEventList;

	// Token: 0x04000015 RID: 21
	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x78")]
	private readonly List<DamageDebugManager.LineDebugInfo> _lineList;

	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public class ShapeDebugInfo
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ShapeDebugInfo()
		{
		}

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x10")]
		public float _time;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x18")]
		public GameObject _displayObject;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x20")]
		public bool _player;
	}

	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public class DamageEvent
	{
		// Token: 0x0600002C RID: 44 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public DamageEvent()
		{
		}

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 _position;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x1C")]
		public float _time;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x20")]
		public float _damage;
	}

	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public class LineDebugInfo
	{
		// Token: 0x0600002D RID: 45 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public LineDebugInfo()
		{
		}

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x10")]
		public float _time;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 _startPos;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 _endPos;
	}
}
