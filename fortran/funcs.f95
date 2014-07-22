module mod_constants
implicit none
	integer, parameter :: DP = 8 !selected_real_kind (15, 307) "64-bit" double
    integer, parameter :: QP = selected_real_kind (33, 4931) ! "128-bit" double
end module mod_constants

module mod_funcs
use mod_constants
implicit none
contains
!============================================================================
	function mins2secs(tmins) result(tsecs)
	real(DP), intent(in)	:: tmins
    real(DP)				:: tsecs
    tsecs = tmins * 60.0_DP
    end function
!============================================================================
	function secs2mins(tsecs) result(tmins)
	real(DP), intent(in)	:: tsecs
    real(DP)				:: tmins
    tmins = tsecs / 60.0_DP
    end function
!============================================================================
end module mod_funcs

program run
	use mod_funcs
	real(DP) :: testVal = 10.0_DP
	write(*,*) mins2secs(testVal)
	write(*,*) sizeof(secs2mins(testVal))
end program run



