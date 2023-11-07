import time
import keyboard
import pyautogui
import win32api
import win32con
from datetime import datetime


time.sleep(2)
n = 0


def click():
    win32api.mouse_event(win32con.MOUSEEVENTF_LEFTDOWN, 0, 0)
    win32api.mouse_event(win32con.MOUSEEVENTF_LEFTUP, 0, 0)
    time.sleep(0.1)


def controls():
    purchase_area = (1600, 130, 300, 900)
    if keyboard.is_pressed('1'):
        cursor = pyautogui.locateCenterOnScreen('cursor.jpg', region=purchase_area, grayscale=True,
                                                confidence=0.70)
        pyautogui.moveTo(cursor)
        time.sleep(.25)
    if keyboard.is_pressed('2'):
        grandma = pyautogui.locateCenterOnScreen('grandma.jpg', region=purchase_area, grayscale=True,
                                                 confidence=0.70)
        pyautogui.moveTo(grandma)
        time.sleep(.25)
    if keyboard.is_pressed('3'):
        farm = pyautogui.locateCenterOnScreen('farm.jpg', region=purchase_area, grayscale=True,
                                              confidence=0.70)
        pyautogui.moveTo(farm)
        time.sleep(.25)
    if keyboard.is_pressed('4'):
        mine = pyautogui.locateCenterOnScreen('mine.jpg', region=purchase_area, grayscale=True,
                                              confidence=0.70)
        pyautogui.moveTo(mine)
        time.sleep(.25)
    if keyboard.is_pressed('5'):
        factory = pyautogui.locateCenterOnScreen('factory.jpg', region=purchase_area, grayscale=True,
                                                 confidence=0.70)
        pyautogui.moveTo(factory)
        time.sleep(.25)
    if keyboard.is_pressed('6'):
        bank = pyautogui.locateCenterOnScreen('bank.jpg', region=purchase_area, grayscale=True,
                                              confidence=0.70)
        pyautogui.moveTo(bank)
        time.sleep(.25)
    if keyboard.is_pressed('7'):
        temple = pyautogui.locateCenterOnScreen('temple.jpg', region=purchase_area, grayscale=True,
                                                confidence=0.70)
        pyautogui.moveTo(temple)
        time.sleep(.25)
    if keyboard.is_pressed('8'):
        wizard = pyautogui.locateCenterOnScreen('wizard.jpg', region=purchase_area, grayscale=True,
                                                confidence=0.70)
        pyautogui.moveTo(wizard)
        time.sleep(.25)
    if keyboard.is_pressed('9'):
        shipment = pyautogui.locateCenterOnScreen('shipment.jpg', region=purchase_area, grayscale=True,
                                                  confidence=0.70)
        pyautogui.moveTo(shipment)
        time.sleep(.25)
    if keyboard.is_pressed('0'):
        alchemy = pyautogui.locateCenterOnScreen('alchemy.jpg', region=purchase_area, grayscale=True,
                                                 confidence=0.70)
        pyautogui.moveTo(alchemy)
        time.sleep(.25)
    # misc
    if keyboard.is_pressed('u'):
        pyautogui.moveTo(1625, 225)
        time.sleep(.25)
    if keyboard.is_pressed('p'):
        time.sleep(5)
# 1 cursor
# 2 grandma
# 3 farm
# 4 mine
# 5 factory
# 6 bank
# 7 temple
# 8
# 9
# 0
# p pause
# u upgrade


while not keyboard.is_pressed('q'):

    controls()
    pyautogui.moveTo(300, 500)
    golden_cookie = pyautogui.locateOnScreen('cookie.jpg', region=(0, 130, 1600, 1030), grayscale=True, confidence=0.60)
    if golden_cookie is not None:
        # pyautogui.moveTo(1625, 225)
        # pyautogui.moveTo(1635, 990)
        # pyautogui.moveTo(1635, 345, 1)
        pyautogui.moveTo(golden_cookie)  # Moves the mouse to the coordinates of the image
        click()
        n = n + 1
        now = datetime.now()
        current_time = now.strftime("%H:%M:%S")
        print("total cookies collected:", n, "\ttime:", current_time)
