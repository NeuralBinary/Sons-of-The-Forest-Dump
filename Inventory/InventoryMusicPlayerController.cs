using System;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Items;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace Sons.Inventory
{
	// Token: 0x020005DE RID: 1502
	[Token(Token = "0x20005DE")]
	[AddComponentMenu("Sons/Inventory/InventoryMusicPlayerController")]
	public class InventoryMusicPlayerController : MonoBehaviour
	{
		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x0600267F RID: 9855 RVA: 0x0000B4F0 File Offset: 0x000096F0
		[Token(Token = "0x17000527")]
		public bool IsPowerOn
		{
			[Token(Token = "0x600267F")]
			[Address(RVA = "0x2DA3BF0", Offset = "0x2DA2BF0", VA = "0x182DA3BF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002680 RID: 9856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002680")]
		[Address(RVA = "0x2DA3920", Offset = "0x2DA2920", VA = "0x182DA3920")]
		private void Start()
		{
		}

		// Token: 0x06002681 RID: 9857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002681")]
		[Address(RVA = "0x2DA3370", Offset = "0x2DA2370", VA = "0x182DA3370")]
		private void OnEnable()
		{
		}

		// Token: 0x06002682 RID: 9858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002682")]
		[Address(RVA = "0x2DA30F0", Offset = "0x2DA20F0", VA = "0x182DA30F0")]
		private void OnDisable()
		{
		}

		// Token: 0x06002683 RID: 9859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002683")]
		[Address(RVA = "0x2DA3AA0", Offset = "0x2DA2AA0", VA = "0x182DA3AA0")]
		private void TryInteractWithButtons(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06002684 RID: 9860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002684")]
		[Address(RVA = "0x2DA3A70", Offset = "0x2DA2A70", VA = "0x182DA3A70")]
		private void TogglePower()
		{
		}

		// Token: 0x06002685 RID: 9861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002685")]
		[Address(RVA = "0x2DA37A0", Offset = "0x2DA27A0", VA = "0x182DA37A0")]
		private static void SetupButton(GameObject buttonObject, UnityAction onEnter, UnityAction onExit, ref MeshOutliner outMeshOutliner)
		{
		}

		// Token: 0x06002686 RID: 9862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002686")]
		[Address(RVA = "0x2DA3700", Offset = "0x2DA2700", VA = "0x182DA3700")]
		private void OnSongSwitchEnter()
		{
		}

		// Token: 0x06002687 RID: 9863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002687")]
		[Address(RVA = "0x2DA3730", Offset = "0x2DA2730", VA = "0x182DA3730")]
		private void OnSongSwitchExit()
		{
		}

		// Token: 0x06002688 RID: 9864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002688")]
		[Address(RVA = "0x2DA3680", Offset = "0x2DA2680", VA = "0x182DA3680")]
		private void OnPowerSwitchOnEnter()
		{
		}

		// Token: 0x06002689 RID: 9865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002689")]
		[Address(RVA = "0x2DA36B0", Offset = "0x2DA26B0", VA = "0x182DA36B0")]
		private void OnPowerSwitchOnExit()
		{
		}

		// Token: 0x0600268A RID: 9866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600268A")]
		[Address(RVA = "0x2DA36E0", Offset = "0x2DA26E0", VA = "0x182DA36E0")]
		private void OnSongChanged(EventInstance eventInstance)
		{
		}

		// Token: 0x0600268B RID: 9867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600268B")]
		[Address(RVA = "0x2DA3780", Offset = "0x2DA2780", VA = "0x182DA3780")]
		public void SetVolume(float volume)
		{
		}

		// Token: 0x0600268C RID: 9868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600268C")]
		[Address(RVA = "0x2DA3BD0", Offset = "0x2DA2BD0", VA = "0x182DA3BD0")]
		public void TurnOn()
		{
		}

		// Token: 0x0600268D RID: 9869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600268D")]
		[Address(RVA = "0x2DA3BB0", Offset = "0x2DA2BB0", VA = "0x182DA3BB0")]
		public void TurnOff()
		{
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600268E")]
		[Address(RVA = "0x2DA3760", Offset = "0x2DA2760", VA = "0x182DA3760")]
		public void PlayNextSong()
		{
		}

		// Token: 0x0600268F RID: 9871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600268F")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public InventoryMusicPlayerController()
		{
		}

		// Token: 0x040022F2 RID: 8946
		[Token(Token = "0x40022F2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private FMODSpectrumData _fmodSpectrumData;

		// Token: 0x040022F3 RID: 8947
		[Token(Token = "0x40022F3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _powerSwitchMesh;

		// Token: 0x040022F4 RID: 8948
		[Token(Token = "0x40022F4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _songSwitchMesh;

		// Token: 0x040022F5 RID: 8949
		[Token(Token = "0x40022F5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[EventRef]
		private string _powerClickAudioEvent;

		// Token: 0x040022F6 RID: 8950
		[Token(Token = "0x40022F6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[EventRef]
		private string _songClickAudioEvent;

		// Token: 0x040022F7 RID: 8951
		[Token(Token = "0x40022F7")]
		[FieldOffset(Offset = "0x48")]
		private bool _isOverPowerSwitch;

		// Token: 0x040022F8 RID: 8952
		[Token(Token = "0x40022F8")]
		[FieldOffset(Offset = "0x49")]
		private bool _isOverSongSwitch;

		// Token: 0x040022F9 RID: 8953
		[Token(Token = "0x40022F9")]
		[FieldOffset(Offset = "0x50")]
		private MusicPlayerController _musicPlayerController;

		// Token: 0x040022FA RID: 8954
		[Token(Token = "0x40022FA")]
		[FieldOffset(Offset = "0x58")]
		private MeshOutliner _powerSwitchOffOutliner;

		// Token: 0x040022FB RID: 8955
		[Token(Token = "0x40022FB")]
		[FieldOffset(Offset = "0x60")]
		private MeshOutliner _powerSwitchOnOutliner;

		// Token: 0x040022FC RID: 8956
		[Token(Token = "0x40022FC")]
		[FieldOffset(Offset = "0x68")]
		private MeshOutliner _songSwitchOutliner;
	}
}
