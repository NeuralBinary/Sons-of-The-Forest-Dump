using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TheForest.Utils.WorkSchedulerInterfaces;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons
{
	// Token: 0x020004DC RID: 1244
	[Token(Token = "0x20004DC")]
	[Serializable]
	public class DistanceActivatedGroup : MonoBehaviour, IThreadSafeTask
	{
		// Token: 0x06001FD8 RID: 8152 RVA: 0x00009360 File Offset: 0x00007560
		[Token(Token = "0x6001FD8")]
		[Address(RVA = "0x54D420", Offset = "0x54C420", VA = "0x18054D420")]
		private static Color ActiveRadiusColor()
		{
			return default(Color);
		}

		// Token: 0x06001FD9 RID: 8153 RVA: 0x00009378 File Offset: 0x00007578
		[Token(Token = "0x6001FD9")]
		[Address(RVA = "0x2D27420", Offset = "0x2D26420", VA = "0x182D27420")]
		private static Color ActiveRadiusColorGui()
		{
			return default(Color);
		}

		// Token: 0x06001FDA RID: 8154 RVA: 0x00009390 File Offset: 0x00007590
		[Token(Token = "0x6001FDA")]
		[Address(RVA = "0x2D27960", Offset = "0x2D26960", VA = "0x182D27960")]
		private static Color RadiusColor()
		{
			return default(Color);
		}

		// Token: 0x06001FDB RID: 8155 RVA: 0x000093A8 File Offset: 0x000075A8
		[Token(Token = "0x6001FDB")]
		[Address(RVA = "0x2D27910", Offset = "0x2D26910", VA = "0x182D27910")]
		private static Color RadiusColorGui()
		{
			return default(Color);
		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x000093C0 File Offset: 0x000075C0
		[Token(Token = "0x6001FDC")]
		[Address(RVA = "0x2D277D0", Offset = "0x2D267D0", VA = "0x182D277D0")]
		private static Color ObjectRadiusColor()
		{
			return default(Color);
		}

		// Token: 0x06001FDD RID: 8157 RVA: 0x000093D8 File Offset: 0x000075D8
		[Token(Token = "0x6001FDD")]
		[Address(RVA = "0x2D27780", Offset = "0x2D26780", VA = "0x182D27780")]
		private static Color ObjectRadiusColorGui()
		{
			return default(Color);
		}

		// Token: 0x06001FDE RID: 8158 RVA: 0x000093F0 File Offset: 0x000075F0
		[Token(Token = "0x6001FDE")]
		[Address(RVA = "0x2D27770", Offset = "0x2D26770", VA = "0x182D27770")]
		private static Color ObjectFindColor()
		{
			return default(Color);
		}

		// Token: 0x06001FDF RID: 8159 RVA: 0x00009408 File Offset: 0x00007608
		[Token(Token = "0x6001FDF")]
		[Address(RVA = "0x2D27720", Offset = "0x2D26720", VA = "0x182D27720")]
		private static Color ObjectFindColorGui()
		{
			return default(Color);
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06001FE0 RID: 8160 RVA: 0x00009420 File Offset: 0x00007620
		// (set) Token: 0x06001FE1 RID: 8161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000475")]
		public bool ShouldDoMainThreadRefresh
		{
			[Token(Token = "0x6001FE0")]
			[Address(RVA = "0x25B46C0", Offset = "0x25B36C0", VA = "0x1825B46C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001FE1")]
			[Address(RVA = "0x260E0B0", Offset = "0x260D0B0", VA = "0x18260E0B0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x00009438 File Offset: 0x00007638
		[Token(Token = "0x6001FE2")]
		[Address(RVA = "0x2D27E50", Offset = "0x2D26E50", VA = "0x182D27E50")]
		private bool ShouldBeActive(float rangeOffset = 0f)
		{
			return default(bool);
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x00009450 File Offset: 0x00007650
		[Token(Token = "0x6001FE3")]
		[Address(RVA = "0x2D27640", Offset = "0x2D26640", VA = "0x182D27640")]
		private float GetFinalRadius()
		{
			return default(float);
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE4")]
		[Address(RVA = "0x2D27820", Offset = "0x2D26820", VA = "0x182D27820")]
		private void OnEnable()
		{
		}

		// Token: 0x06001FE5 RID: 8165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE5")]
		[Address(RVA = "0x2D277E0", Offset = "0x2D267E0", VA = "0x182D277E0")]
		private void OnDisable()
		{
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE6")]
		[Address(RVA = "0x2D27410", Offset = "0x2D26410", VA = "0x182D27410")]
		private void ActivateTargets()
		{
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE7")]
		[Address(RVA = "0x2D27470", Offset = "0x2D26470", VA = "0x182D27470")]
		private void DeactivateTargets()
		{
		}

		// Token: 0x06001FE8 RID: 8168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE8")]
		[Address(RVA = "0x2D27CE0", Offset = "0x2D26CE0", VA = "0x182D27CE0")]
		private void SetTargetsActive(bool value)
		{
		}

		// Token: 0x06001FE9 RID: 8169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE9")]
		[Address(RVA = "0x2D27F10", Offset = "0x2D26F10", VA = "0x182D27F10", Slot = "6")]
		public void ThreadedRefresh()
		{
		}

		// Token: 0x06001FEA RID: 8170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FEA")]
		[Address(RVA = "0x2D28190", Offset = "0x2D27190", VA = "0x182D28190")]
		private void UpdateShouldBeActive()
		{
		}

		// Token: 0x06001FEB RID: 8171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FEB")]
		[Address(RVA = "0x2D27650", Offset = "0x2D26650", VA = "0x182D27650", Slot = "7")]
		public void MainThreadRefresh()
		{
		}

		// Token: 0x06001FEC RID: 8172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FEC")]
		[Address(RVA = "0x2D27F90", Offset = "0x2D26F90", VA = "0x182D27F90")]
		private void UnregisterActiveGroup()
		{
		}

		// Token: 0x06001FED RID: 8173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FED")]
		[Address(RVA = "0x2D27970", Offset = "0x2D26970", VA = "0x182D27970")]
		private void RegisterActiveGroup()
		{
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FEE")]
		[Address(RVA = "0x5A2410", Offset = "0x5A1410", VA = "0x1805A2410", Slot = "8")]
		public string GetTaskName()
		{
			return null;
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x00009468 File Offset: 0x00007668
		[Token(Token = "0x6001FEF")]
		[Address(RVA = "0x2D27480", Offset = "0x2D26480", VA = "0x182D27480")]
		public static int GetActiveGroupCount()
		{
			return default(int);
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FF0")]
		[Address(RVA = "0x2D28270", Offset = "0x2D27270", VA = "0x182D28270")]
		public DistanceActivatedGroup()
		{
		}

		// Token: 0x04001D6D RID: 7533
		[Token(Token = "0x4001D6D")]
		[FieldOffset(Offset = "0x0")]
		private static List<WeakReference<DistanceActivatedGroup>> _activeGroups;

		// Token: 0x04001D6E RID: 7534
		[Token(Token = "0x4001D6E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _radius;

		// Token: 0x04001D6F RID: 7535
		[Token(Token = "0x4001D6F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _activeRadius;

		// Token: 0x04001D70 RID: 7536
		[Token(Token = "0x4001D70")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _objectRadius;

		// Token: 0x04001D71 RID: 7537
		[Token(Token = "0x4001D71")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Vector3 _objectCenter;

		// Token: 0x04001D72 RID: 7538
		[Token(Token = "0x4001D72")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<GameObject> _targetGameObjects;

		// Token: 0x04001D73 RID: 7539
		[Token(Token = "0x4001D73")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _ignorePosition;

		// Token: 0x04001D74 RID: 7540
		[Token(Token = "0x4001D74")]
		[FieldOffset(Offset = "0x41")]
		[SerializeField]
		private bool _startDisabled;

		// Token: 0x04001D75 RID: 7541
		[Token(Token = "0x4001D75")]
		[FieldOffset(Offset = "0x44")]
		[FormerlySerializedAs("_siblingSelectionRadius")]
		[SerializeField]
		private float _siblingFindRadius;

		// Token: 0x04001D76 RID: 7542
		[Token(Token = "0x4001D76")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<Transform> _siblingFindParents;

		// Token: 0x04001D77 RID: 7543
		[Token(Token = "0x4001D77")]
		private const string NamePrefix = "DistanceActivatedGroup";

		// Token: 0x04001D78 RID: 7544
		[Token(Token = "0x4001D78")]
		[FieldOffset(Offset = "0x50")]
		private DateTime _lastTime;

		// Token: 0x04001D79 RID: 7545
		[Token(Token = "0x4001D79")]
		[FieldOffset(Offset = "0x58")]
		private bool _isActive;

		// Token: 0x04001D7A RID: 7546
		[Token(Token = "0x4001D7A")]
		[FieldOffset(Offset = "0x59")]
		private bool _shouldBeActive;

		// Token: 0x04001D7B RID: 7547
		[Token(Token = "0x4001D7B")]
		[FieldOffset(Offset = "0x5C")]
		private float _distanceToPlayer;

		// Token: 0x04001D7C RID: 7548
		[Token(Token = "0x4001D7C")]
		[FieldOffset(Offset = "0x60")]
		private string _cachedName;

		// Token: 0x04001D7D RID: 7549
		[Token(Token = "0x4001D7D")]
		[FieldOffset(Offset = "0x68")]
		private int _wsToken;

		// Token: 0x04001D7E RID: 7550
		[Token(Token = "0x4001D7E")]
		[FieldOffset(Offset = "0x6C")]
		private bool _registeredAsActive;
	}
}
