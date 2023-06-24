using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TheForest.Utils.WorkSchedulerInterfaces;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons
{
	// Token: 0x020004D1 RID: 1233
	[Token(Token = "0x20004D1")]
	[Serializable]
	public class DistanceActivatedGroup : MonoBehaviour, IThreadSafeTask
	{
		// Token: 0x0600203C RID: 8252 RVA: 0x000096C0 File Offset: 0x000078C0
		[Token(Token = "0x600203C")]
		[Address(RVA = "0x5E8F40", Offset = "0x5E7540", VA = "0x1805E8F40")]
		private static Color ActiveRadiusColor()
		{
			return default(Color);
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x000096D8 File Offset: 0x000078D8
		[Token(Token = "0x600203D")]
		[Address(RVA = "0x3312340", Offset = "0x3310940", VA = "0x183312340")]
		private static Color ActiveRadiusColorGui()
		{
			return default(Color);
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x000096F0 File Offset: 0x000078F0
		[Token(Token = "0x600203E")]
		[Address(RVA = "0x5E8F30", Offset = "0x5E7530", VA = "0x1805E8F30")]
		private static Color RadiusColor()
		{
			return default(Color);
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x00009708 File Offset: 0x00007908
		[Token(Token = "0x600203F")]
		[Address(RVA = "0x3312390", Offset = "0x3310990", VA = "0x183312390")]
		private static Color RadiusColorGui()
		{
			return default(Color);
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x00009720 File Offset: 0x00007920
		[Token(Token = "0x6002040")]
		[Address(RVA = "0x33123E0", Offset = "0x33109E0", VA = "0x1833123E0")]
		private static Color ObjectRadiusColor()
		{
			return default(Color);
		}

		// Token: 0x06002041 RID: 8257 RVA: 0x00009738 File Offset: 0x00007938
		[Token(Token = "0x6002041")]
		[Address(RVA = "0x33123F0", Offset = "0x33109F0", VA = "0x1833123F0")]
		private static Color ObjectRadiusColorGui()
		{
			return default(Color);
		}

		// Token: 0x06002042 RID: 8258 RVA: 0x00009750 File Offset: 0x00007950
		[Token(Token = "0x6002042")]
		[Address(RVA = "0x3312440", Offset = "0x3310A40", VA = "0x183312440")]
		private static Color ObjectFindColor()
		{
			return default(Color);
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x00009768 File Offset: 0x00007968
		[Token(Token = "0x6002043")]
		[Address(RVA = "0x3312450", Offset = "0x3310A50", VA = "0x183312450")]
		private static Color ObjectFindColorGui()
		{
			return default(Color);
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06002044 RID: 8260 RVA: 0x00009780 File Offset: 0x00007980
		// (set) Token: 0x06002045 RID: 8261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000484")]
		public bool ShouldDoMainThreadRefresh
		{
			[Token(Token = "0x6002044")]
			[Address(RVA = "0x7283F0", Offset = "0x7269F0", VA = "0x1807283F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002045")]
			[Address(RVA = "0x270DF00", Offset = "0x270C500", VA = "0x18270DF00", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x00009798 File Offset: 0x00007998
		[Token(Token = "0x6002046")]
		[Address(RVA = "0x33124A0", Offset = "0x3310AA0", VA = "0x1833124A0")]
		private bool ShouldBeActive(float rangeOffset = 0f)
		{
			return default(bool);
		}

		// Token: 0x06002047 RID: 8263 RVA: 0x000097B0 File Offset: 0x000079B0
		[Token(Token = "0x6002047")]
		[Address(RVA = "0x3312640", Offset = "0x3310C40", VA = "0x183312640")]
		private float GetFinalRadius()
		{
			return 0f;
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002048")]
		[Address(RVA = "0x3312650", Offset = "0x3310C50", VA = "0x183312650")]
		private void OnEnable()
		{
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002049")]
		[Address(RVA = "0x33127E0", Offset = "0x3310DE0", VA = "0x1833127E0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600204A")]
		[Address(RVA = "0x3312820", Offset = "0x3310E20", VA = "0x183312820")]
		private void ActivateTargets()
		{
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600204B")]
		[Address(RVA = "0x3312830", Offset = "0x3310E30", VA = "0x183312830")]
		private void DeactivateTargets()
		{
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600204C")]
		[Address(RVA = "0x3312840", Offset = "0x3310E40", VA = "0x183312840")]
		private void SetTargetsActive(bool value)
		{
		}

		// Token: 0x0600204D RID: 8269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600204D")]
		[Address(RVA = "0x3312A50", Offset = "0x3311050", VA = "0x183312A50", Slot = "6")]
		public void ThreadedRefresh()
		{
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600204E")]
		[Address(RVA = "0x3312AD0", Offset = "0x33110D0", VA = "0x183312AD0")]
		private void UpdateShouldBeActive()
		{
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600204F")]
		[Address(RVA = "0x3312B20", Offset = "0x3311120", VA = "0x183312B20", Slot = "7")]
		public void MainThreadRefresh()
		{
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002050")]
		[Address(RVA = "0x3312C30", Offset = "0x3311230", VA = "0x183312C30")]
		private void UnregisterActiveGroup()
		{
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002051")]
		[Address(RVA = "0x3312FA0", Offset = "0x33115A0", VA = "0x183312FA0")]
		private void RegisterActiveGroup()
		{
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002052")]
		[Address(RVA = "0x675FA0", Offset = "0x6745A0", VA = "0x180675FA0", Slot = "8")]
		public string GetTaskName()
		{
			return null;
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x000097C8 File Offset: 0x000079C8
		[Token(Token = "0x6002053")]
		[Address(RVA = "0x3313420", Offset = "0x3311A20", VA = "0x183313420")]
		public static int GetActiveGroupCount()
		{
			return 0;
		}

		// Token: 0x06002054 RID: 8276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002054")]
		[Address(RVA = "0x33135E0", Offset = "0x3311BE0", VA = "0x1833135E0")]
		public DistanceActivatedGroup()
		{
		}

		// Token: 0x04001DA9 RID: 7593
		[Token(Token = "0x4001DA9")]
		[FieldOffset(Offset = "0x0")]
		private static List<WeakReference<DistanceActivatedGroup>> _activeGroups;

		// Token: 0x04001DAA RID: 7594
		[Token(Token = "0x4001DAA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _radius;

		// Token: 0x04001DAB RID: 7595
		[Token(Token = "0x4001DAB")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _activeRadius;

		// Token: 0x04001DAC RID: 7596
		[Token(Token = "0x4001DAC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _objectRadius;

		// Token: 0x04001DAD RID: 7597
		[Token(Token = "0x4001DAD")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Vector3 _objectCenter;

		// Token: 0x04001DAE RID: 7598
		[Token(Token = "0x4001DAE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<GameObject> _targetGameObjects;

		// Token: 0x04001DAF RID: 7599
		[Token(Token = "0x4001DAF")]
		[FieldOffset(Offset = "0x40")]
		[FormerlySerializedAs("_ignoreGameObjects")]
		[SerializeField]
		private List<GameObject> _excludeGameObjects;

		// Token: 0x04001DB0 RID: 7600
		[Token(Token = "0x4001DB0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _ignorePosition;

		// Token: 0x04001DB1 RID: 7601
		[Token(Token = "0x4001DB1")]
		[FieldOffset(Offset = "0x49")]
		[SerializeField]
		private bool _startDisabled;

		// Token: 0x04001DB2 RID: 7602
		[Token(Token = "0x4001DB2")]
		[FieldOffset(Offset = "0x4C")]
		[FormerlySerializedAs("_siblingSelectionRadius")]
		[SerializeField]
		private float _siblingFindRadius;

		// Token: 0x04001DB3 RID: 7603
		[Token(Token = "0x4001DB3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<Transform> _siblingFindParents;

		// Token: 0x04001DB4 RID: 7604
		[Token(Token = "0x4001DB4")]
		private const string NamePrefix = "DistanceActivatedGroup";

		// Token: 0x04001DB5 RID: 7605
		[Token(Token = "0x4001DB5")]
		[FieldOffset(Offset = "0x58")]
		private DateTime _lastTime;

		// Token: 0x04001DB6 RID: 7606
		[Token(Token = "0x4001DB6")]
		[FieldOffset(Offset = "0x60")]
		private bool _isActive;

		// Token: 0x04001DB7 RID: 7607
		[Token(Token = "0x4001DB7")]
		[FieldOffset(Offset = "0x61")]
		private bool _shouldBeActive;

		// Token: 0x04001DB8 RID: 7608
		[Token(Token = "0x4001DB8")]
		[FieldOffset(Offset = "0x64")]
		private float _distanceToPlayer;

		// Token: 0x04001DB9 RID: 7609
		[Token(Token = "0x4001DB9")]
		[FieldOffset(Offset = "0x68")]
		private string _cachedName;

		// Token: 0x04001DBA RID: 7610
		[Token(Token = "0x4001DBA")]
		[FieldOffset(Offset = "0x70")]
		private int _wsToken;

		// Token: 0x04001DBB RID: 7611
		[Token(Token = "0x4001DBB")]
		[FieldOffset(Offset = "0x74")]
		private bool _registeredAsActive;
	}
}
