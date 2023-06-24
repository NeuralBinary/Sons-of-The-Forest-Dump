using System;
using Il2CppDummyDll;
using Sons.Input;

namespace Construction
{
	// Token: 0x02000259 RID: 601
	[Token(Token = "0x2000259")]
	public static class ConstructionInput
	{
		// Token: 0x06001268 RID: 4712 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001268")]
		[Address(RVA = "0x2F39D90", Offset = "0x2F38390", VA = "0x182F39D90")]
		public static void RecordPrevActionStates()
		{
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x0000B33C File Offset: 0x0000953C
		[Token(Token = "0x6001269")]
		[Address(RVA = "0x2F39E10", Offset = "0x2F38410", VA = "0x182F39E10")]
		public static bool PlaceDown()
		{
			return default(bool);
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x0000B354 File Offset: 0x00009554
		[Token(Token = "0x600126A")]
		[Address(RVA = "0x2F39EA0", Offset = "0x2F384A0", VA = "0x182F39EA0")]
		public static bool PlaceUp()
		{
			return default(bool);
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x0000B36C File Offset: 0x0000956C
		[Token(Token = "0x600126B")]
		[Address(RVA = "0x2F39F20", Offset = "0x2F38520", VA = "0x182F39F20")]
		public static bool PlaceLongPress()
		{
			return default(bool);
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x0000B384 File Offset: 0x00009584
		[Token(Token = "0x600126C")]
		[Address(RVA = "0x2F39FA0", Offset = "0x2F385A0", VA = "0x182F39FA0")]
		public static bool PlaceSecondary()
		{
			return default(bool);
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x0000B39C File Offset: 0x0000959C
		[Token(Token = "0x600126D")]
		[Address(RVA = "0x2F3A030", Offset = "0x2F38630", VA = "0x182F3A030")]
		public static bool Cut()
		{
			return default(bool);
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x0000B3B4 File Offset: 0x000095B4
		[Token(Token = "0x600126E")]
		[Address(RVA = "0x2F3A0C0", Offset = "0x2F386C0", VA = "0x182F3A0C0")]
		public static bool Cancel()
		{
			return default(bool);
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x0000B3CC File Offset: 0x000095CC
		[Token(Token = "0x600126F")]
		[Address(RVA = "0x2F3A150", Offset = "0x2F38750", VA = "0x182F3A150")]
		public static bool ToggleModeDown()
		{
			return default(bool);
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x0000B3E4 File Offset: 0x000095E4
		[Token(Token = "0x6001270")]
		[Address(RVA = "0x2F3A1E0", Offset = "0x2F387E0", VA = "0x182F3A1E0")]
		public static bool DismantleHeld()
		{
			return default(bool);
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x0000B3FC File Offset: 0x000095FC
		[Token(Token = "0x6001271")]
		[Address(RVA = "0x2F3A250", Offset = "0x2F38850", VA = "0x182F3A250")]
		public static bool DismantleLongPress()
		{
			return default(bool);
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x0000B414 File Offset: 0x00009614
		[Token(Token = "0x6001272")]
		[Address(RVA = "0x2F3A2D0", Offset = "0x2F388D0", VA = "0x182F3A2D0")]
		public static bool DismantleCancel()
		{
			return default(bool);
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001273")]
		[Address(RVA = "0x2F3A350", Offset = "0x2F38950", VA = "0x182F3A350")]
		public static void DismantleReset()
		{
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x0000B42C File Offset: 0x0000962C
		[Token(Token = "0x6001274")]
		[Address(RVA = "0x2F3A3C0", Offset = "0x2F389C0", VA = "0x182F3A3C0")]
		public static bool RotateHeld(out float val)
		{
			return default(bool);
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x0000B444 File Offset: 0x00009644
		[Token(Token = "0x6001275")]
		[Address(RVA = "0x2F3A470", Offset = "0x2F38A70", VA = "0x182F3A470")]
		public static bool ConsumeIngredientDown()
		{
			return default(bool);
		}

		// Token: 0x04000928 RID: 2344
		[Token(Token = "0x4000928")]
		[FieldOffset(Offset = "0x0")]
		private static readonly InputSystem.Action PlaceElement;

		// Token: 0x04000929 RID: 2345
		[Token(Token = "0x4000929")]
		[FieldOffset(Offset = "0x10")]
		private static readonly InputSystem.Action CutElement;

		// Token: 0x0400092A RID: 2346
		[Token(Token = "0x400092A")]
		[FieldOffset(Offset = "0x20")]
		private static readonly InputSystem.Action RotateElement;

		// Token: 0x0400092B RID: 2347
		[Token(Token = "0x400092B")]
		[FieldOffset(Offset = "0x30")]
		private static readonly InputSystem.Action CancelPlace;

		// Token: 0x0400092C RID: 2348
		[Token(Token = "0x400092C")]
		[FieldOffset(Offset = "0x40")]
		private static readonly InputSystem.Action TogglePlaceMode;

		// Token: 0x0400092D RID: 2349
		[Token(Token = "0x400092D")]
		[FieldOffset(Offset = "0x50")]
		private static readonly InputSystem.Action DismantleElement;

		// Token: 0x0400092E RID: 2350
		[Token(Token = "0x400092E")]
		[FieldOffset(Offset = "0x60")]
		private static readonly InputSystem.Action ConsumeIngredient;

		// Token: 0x0400092F RID: 2351
		[Token(Token = "0x400092F")]
		[FieldOffset(Offset = "0x70")]
		private static readonly ConstructionInput.PollInput PlaceElementAction;

		// Token: 0x04000930 RID: 2352
		[Token(Token = "0x4000930")]
		[FieldOffset(Offset = "0x78")]
		private static readonly ConstructionInput.PollInput DismantleElementAction;

		// Token: 0x0200025A RID: 602
		[Token(Token = "0x200025A")]
		public class PollInput
		{
			// Token: 0x1700041F RID: 1055
			// (get) Token: 0x06001277 RID: 4727 RVA: 0x0000B45C File Offset: 0x0000965C
			[Token(Token = "0x1700041F")]
			public bool Down
			{
				[Token(Token = "0x6001277")]
				[Address(RVA = "0x2F3AA30", Offset = "0x2F39030", VA = "0x182F3AA30")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000420 RID: 1056
			// (get) Token: 0x06001278 RID: 4728 RVA: 0x0000B474 File Offset: 0x00009674
			[Token(Token = "0x17000420")]
			public bool Held
			{
				[Token(Token = "0x6001278")]
				[Address(RVA = "0x2F3AA60", Offset = "0x2F39060", VA = "0x182F3AA60")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000421 RID: 1057
			// (get) Token: 0x06001279 RID: 4729 RVA: 0x0000B48C File Offset: 0x0000968C
			[Token(Token = "0x17000421")]
			public bool Up
			{
				[Token(Token = "0x6001279")]
				[Address(RVA = "0x2F3AA70", Offset = "0x2F39070", VA = "0x182F3AA70")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000422 RID: 1058
			// (get) Token: 0x0600127A RID: 4730 RVA: 0x0000B4A4 File Offset: 0x000096A4
			[Token(Token = "0x17000422")]
			public bool LongPress
			{
				[Token(Token = "0x600127A")]
				[Address(RVA = "0x2F3AA90", Offset = "0x2F39090", VA = "0x182F3AA90")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000423 RID: 1059
			// (get) Token: 0x0600127B RID: 4731 RVA: 0x0000B4BC File Offset: 0x000096BC
			[Token(Token = "0x17000423")]
			public bool LongPressAborted
			{
				[Token(Token = "0x600127B")]
				[Address(RVA = "0x2F3AAB0", Offset = "0x2F390B0", VA = "0x182F3AAB0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600127C RID: 4732 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600127C")]
			[Address(RVA = "0x2F3AAD0", Offset = "0x2F390D0", VA = "0x182F3AAD0")]
			public PollInput(InputSystem.Action targetAction)
			{
			}

			// Token: 0x0600127D RID: 4733 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600127D")]
			[Address(RVA = "0x2099880", Offset = "0x2097E80", VA = "0x182099880")]
			public void RegisterPrevState()
			{
			}

			// Token: 0x0600127E RID: 4734 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600127E")]
			[Address(RVA = "0x2F3AC50", Offset = "0x2F39250", VA = "0x182F3AC50")]
			private void SetActionState(ConstructionInput.PollInput.ActionState actionState)
			{
			}

			// Token: 0x0600127F RID: 4735 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600127F")]
			[Address(RVA = "0x2F3AC60", Offset = "0x2F39260", VA = "0x182F3AC60")]
			private void SetupCallBacks(InputSystem.Action action)
			{
			}

			// Token: 0x06001280 RID: 4736 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6001280")]
			[Address(RVA = "0x2F3AD90", Offset = "0x2F39390", VA = "0x182F3AD90")]
			public void Reset()
			{
			}

			// Token: 0x04000931 RID: 2353
			[Token(Token = "0x4000931")]
			[FieldOffset(Offset = "0x10")]
			private InputSystem.Action _targetAction;

			// Token: 0x04000932 RID: 2354
			[Token(Token = "0x4000932")]
			[FieldOffset(Offset = "0x20")]
			private ConstructionInput.PollInput.ActionState ActiveActionStatePrev;

			// Token: 0x04000933 RID: 2355
			[Token(Token = "0x4000933")]
			[FieldOffset(Offset = "0x24")]
			private ConstructionInput.PollInput.ActionState ActiveActionState;

			// Token: 0x04000934 RID: 2356
			[Token(Token = "0x4000934")]
			[FieldOffset(Offset = "0x28")]
			private bool IsHold;

			// Token: 0x0200025B RID: 603
			[Token(Token = "0x200025B")]
			private enum ActionState
			{
				// Token: 0x04000936 RID: 2358
				[Token(Token = "0x4000936")]
				Waiting,
				// Token: 0x04000937 RID: 2359
				[Token(Token = "0x4000937")]
				Started,
				// Token: 0x04000938 RID: 2360
				[Token(Token = "0x4000938")]
				Performed
			}
		}
	}
}
