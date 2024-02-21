# Network Interface Manager
#### Easily swap out network configurations on Windows via netsh. 

# Background:

This project originated as part of a bachelor project work in 2019. 
It required frequent adjustments to the network configuration of our PCs, such as switching from DHCP to static IPs, and doing so for multiple network interfaces. 
To save time, I coded Network Interface Manager, which allows saving and swapping different configurations. Only for Windows, as it uses netsh.
This repository is not actively maintained and is solely for educational purposes.

# Key Takeaways:
### 1. UI Agnostic Data Handling
#### Data binding using BindingList. Ensures dynamic data synchronization. Decoupled from the ui.
### 2. Modular UI with Custom ObjectEditor
#### Similiar to the Windows Forms Editor (with less noise). Allows for automatic UI generation using serializable objects. 

# Preview:

### The Configuration Overview

![The Configuration Overview](./Docs/Interface.png?raw=true "The Configuration Overview")

### Adding a new Configuration

![Adding a Config](./Docs/Add%20Config.png?raw=true "Adding a Config")