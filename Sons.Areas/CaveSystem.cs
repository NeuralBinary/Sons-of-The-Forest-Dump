using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Physics;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Areas
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	[AddComponentMenu("Sons/Word/Cave System")]
	public class CaveSystem : MonoBehaviour
	{
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600004E RID: 78 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x0600004F RID: 79 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000005")]
		private event Action<AreaMask> _onCaveEnteredEvent
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x2D29F50", Offset = "0x2D28550", VA = "0x182D29F50")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x2D2A0C0", Offset = "0x2D286C0", VA = "0x182D2A0C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000050 RID: 80 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000051 RID: 81 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000006")]
		private event Action<AreaMask> _onCaveExitedEvent
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x2D2A230", Offset = "0x2D28830", VA = "0x182D2A230")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x2D2A3A0", Offset = "0x2D289A0", VA = "0x182D2A3A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000052 RID: 82 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000053 RID: 83 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000007")]
		private event Action _onDeepCaveEnteredEvent
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x2D2A510", Offset = "0x2D28B10", VA = "0x182D2A510")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x2D2A600", Offset = "0x2D28C00", VA = "0x182D2A600")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000054 RID: 84 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000055 RID: 85 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000008")]
		private event Action _onDeepCaveExitedEvent
		{
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x2D2A6F0", Offset = "0x2D28CF0", VA = "0x182D2A6F0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x2D2A7E0", Offset = "0x2D28DE0", VA = "0x182D2A7E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void OnValidate()
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
		public AreaMask GetAreaMask()
		{
			return AreaMask.None;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2D2A8D0", Offset = "0x2D28ED0", VA = "0x182D2A8D0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2D2A900", Offset = "0x2D28F00", VA = "0x182D2A900")]
		private void OnDisable()
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x2D2AA00", Offset = "0x2D29000", VA = "0x182D2AA00")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x2D2AA70", Offset = "0x2D29070", VA = "0x182D2AA70")]
		private void RegisterEntranceCallbacks()
		{
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x2D2ACD0", Offset = "0x2D292D0", VA = "0x182D2ACD0")]
		private void UnregisterEntranceCallbacks()
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2D2AF30", Offset = "0x2D29530", VA = "0x182D2AF30")]
		private void RegisterExtentCallbacks()
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x2D2B3A0", Offset = "0x2D299A0", VA = "0x182D2B3A0")]
		private void UnregisterExtentCallbacks()
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x2D2B6A0", Offset = "0x2D29CA0", VA = "0x182D2B6A0")]
		public bool IsInsideExtents(Vector3 location)
		{
			return default(bool);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2D2B790", Offset = "0x2D29D90", VA = "0x182D2B790")]
		private bool IsInsideExtent(Vector3 location, TriggerProxy extent)
		{
			return default(bool);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000021D4 File Offset: 0x000003D4
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2D2B9E0", Offset = "0x2D29FE0", VA = "0x182D2B9E0")]
		private static bool IsInsideExtent(Vector3 location, Collider eachCollider)
		{
			return default(bool);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2D2BD60", Offset = "0x2D2A360", VA = "0x182D2BD60")]
		private void EnterExtent(Collider target, TriggerProxy source)
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2D2BE70", Offset = "0x2D2A470", VA = "0x182D2BE70")]
		private void StayExtent(Collider target, TriggerProxy source)
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2D2BF80", Offset = "0x2D2A580", VA = "0x182D2BF80")]
		private void ExitedExtent(Collider target, TriggerProxy source)
		{
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2D2C0A0", Offset = "0x2D2A6A0", VA = "0x182D2C0A0")]
		public void SetInDeepCave(bool value)
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2D2C0C0", Offset = "0x2D2A6C0", VA = "0x182D2C0C0")]
		private void RequestCheckLeftExtents()
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2D2C160", Offset = "0x2D2A760", VA = "0x182D2C160")]
		private void CheckLeftExtents()
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2D2C380", Offset = "0x2D2A980", VA = "0x182D2C380")]
		public void DoForcedEnter()
		{
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2D2C570", Offset = "0x2D2AB70", VA = "0x182D2C570")]
		public void DoForcedExit()
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2D2C770", Offset = "0x2D2AD70", VA = "0x182D2C770")]
		private void FindEntrancesInChildren()
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2D2C8B0", Offset = "0x2D2AEB0", VA = "0x182D2C8B0")]
		private void OnCaveExit(AreaMask areaId)
		{
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2D2C990", Offset = "0x2D2AF90", VA = "0x182D2C990")]
		private void OnCaveEnter(AreaMask areaId)
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x2D29F50", Offset = "0x2D28550", VA = "0x182D29F50")]
		public void RegisterOnCaveEntered(Action<AreaMask> action)
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2D2A230", Offset = "0x2D28830", VA = "0x182D2A230")]
		public void RegisterOnCaveExited(Action<AreaMask> action)
		{
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2D2A510", Offset = "0x2D28B10", VA = "0x182D2A510")]
		public void RegisterOnDeepCaveEntered(Action action)
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x2D2A6F0", Offset = "0x2D28CF0", VA = "0x182D2A6F0")]
		public void RegisterOnDeepCaveExited(Action action)
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x2D2A0C0", Offset = "0x2D286C0", VA = "0x182D2A0C0")]
		public void UnregisterOnCaveEntered(Action<AreaMask> action)
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x2D2A3A0", Offset = "0x2D289A0", VA = "0x182D2A3A0")]
		public void UnregisterOnCaveExited(Action<AreaMask> action)
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2D2A600", Offset = "0x2D28C00", VA = "0x182D2A600")]
		public void UnregisterOnDeepCaveEntered(Action action)
		{
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2D2A7E0", Offset = "0x2D28DE0", VA = "0x182D2A7E0")]
		public void UnregisterOnDeepCaveExited(Action action)
		{
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2D2CA70", Offset = "0x2D2B070", VA = "0x182D2CA70")]
		public CaveSystem()
		{
		}

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("_caveId")]
		[SerializeField]
		private AreaMask _areaId;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		private const int EnterCallbackIndex = 0;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		private const int ExitCallbackIndex = 1;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		private const int StayCallbackIndex = 2;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<TriggerProxy> _extents;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<CaveEntrance> _entrances;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x38")]
		private List<TriggerProxy> _activeExtents;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x0")]
		private static int _requestCheckLeftExtentsDelayFrames;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x40")]
		private bool _isActive;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x48")]
		private readonly Dictionary<TriggerProxy, Action<Collider>[]> _extentsCallbacks;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x50")]
		private int _requestedCheckLeftExtentsFrame;
	}
}
